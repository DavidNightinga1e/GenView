using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using GenView;
using UnityEditor;
using UnityEngine;

namespace GenViewEditor
{
	public class CodeGen
	{
		private GenViewSettings _settings;

		public CodeGen()
		{
			string[] guids = AssetDatabase.FindAssets("GenViewSettings t:GenViewSettings");
			if (guids.Length is 0)
				throw new Exception("GenViewSettings not found. Make sure there is file named GenViewSettings");

			string guid = guids[0];
			string path = AssetDatabase.GUIDToAssetPath(guid);
			_settings = AssetDatabase.LoadAssetAtPath<GenViewSettings>(path);
			if (_settings is null)
				throw new Exception("Settings not loaded");
		}

		public void GenerateFile(ViewGenerationAssistant assistant)
		{
			string directory = assistant.OutputDirectory;
			string className = assistant.OutputClassName;
			string filePath = CodeGenUtilities.GetPathToFile(directory, className);

			if (File.Exists(filePath))
				File.Delete(filePath);

			FileDescription fileDescription = CreateFileDescription(assistant);

			var sb = new StringBuilder();
			Generate(sb, fileDescription);

			using var writer = new StreamWriter(filePath);
			writer.Write(sb.ToString());
			writer.Close();
		}

		private FileDescription CreateFileDescription(ViewGenerationAssistant assistant)
		{
			var root = new CodeGeneratorComponent(assistant.OutputClassName, assistant.OutputClassName);
			var description = new FileDescription(assistant, root);

			InitializeComponentsRecursive(root, assistant.transform);

			return description;
		}

		public void AddComponentAndSerializeReferences(ViewGenerationAssistant assistant)
		{
			string typeName = CodeGenUtilities.TypeCombine(
				assistant.OutputNamespace,
				assistant.OutputClassName,
				assistant.AssemblyName);
			var type = Type.GetType(typeName);
			if (type is null)
			{
				GenViewLogger.LogError($"Type [{typeName}] not found. Generate file and recompile");
				return;
			}

			Component instance = assistant.gameObject.AddComponent(type);
			FileDescription fileDescription = CreateFileDescription(assistant);

			SerializeRecursive(fileDescription.Root, instance, fileDescription, true);
		}

		private static void SerializeRecursive(CodeGeneratorComponent codeGeneratorComponent, object instance,
			FileDescription fd, bool isRoot = false)
		{
			string typeName = isRoot
				? CodeGenUtilities.TypeCombine(fd.ClassNamespace, fd.ClassName, fd.AssemblyName)
				: CodeGenUtilities.TypeCombine(
					fd.ClassNamespace,
					fd.ClassName,
					codeGeneratorComponent.TypeName,
					fd.AssemblyName);

			var type = Type.GetType(typeName);
			if (type is null)
				throw new ArgumentException($"Type {typeName} not found. Maybe View file isn't compiled");

			var unityComponents = codeGeneratorComponent.UnityComponents;
			foreach (Component unityComponent in unityComponents)
			{
				string componentTypeName = unityComponent.GetType().Name;

				const BindingFlags attr = BindingFlags.NonPublic | BindingFlags.Instance;
				FieldInfo fieldInfo = type.GetField(componentTypeName.ToPrivateField(), attr);

				fieldInfo?.SetValue(instance, unityComponent);
			}

			var children = codeGeneratorComponent.Children;
			foreach (CodeGeneratorComponent child in children)
			{
				string childTypeName = CodeGenUtilities.TypeCombine(
					fd.ClassNamespace,
					fd.ClassName,
					child.TypeName,
					fd.AssemblyName);
				var childType = Type.GetType(childTypeName);
				if (childType is null)
					throw new Exception(
						$"Type {childTypeName} not found. File isn't generated or internal error occured");

				const BindingFlags attr = BindingFlags.NonPublic | BindingFlags.Instance;
				FieldInfo fieldInfo = type.GetField(child.Name.ToPrivateField(), attr);

				if (fieldInfo is null)
					throw new Exception($"Field {child.Name.ToPrivateField()} in type {childTypeName} not found");

				object childInstance = Activator.CreateInstance(childType);
				fieldInfo.SetValue(instance, childInstance);
				SerializeRecursive(child, childInstance, fd);
			}
		}

		private void Generate(StringBuilder sb, FileDescription fileDescription)
		{
			CodeGenSnippets.AddFileSummary(sb);
			CodeGenSnippets.CreateNamespace(sb, fileDescription.ClassNamespace);

			GenerateRecursive(sb, fileDescription.Root, true, _settings.HideInInspector);

			CodeGenSnippets.Close(sb, 0);
		}

		private static void GenerateRecursive(StringBuilder sb, CodeGeneratorComponent root, bool isRoot, bool hideInInspector)
		{
			var classTabCount = isRoot ? 1 : 2;
			int fieldTabCount = classTabCount + 1;

			if (!isRoot)
				CodeGenSnippets.AppendLine(sb);

			// open class
			CodeGenSnippets.CreateClass(sb, root.TypeName, classTabCount, isRoot);

			var children = root.Children;
			var unityComponents = root.UnityComponents;

			// create unity fields
			GenerateUnityComponentFields(sb, unityComponents, fieldTabCount);

			// append new line if necessary 
			int childrenCount = children.Count;
			if (childrenCount is not 0)
				CodeGenSnippets.AppendLine(sb);

			// create child link fields
			GenerateChildComponentsFields(sb, childrenCount, children, fieldTabCount);

			// close inner class here
			if (!isRoot)
				CodeGenSnippets.Close(sb, classTabCount);

			// dive into recursion to create other classes and fill them
			foreach (CodeGeneratorComponent child in children)
				GenerateRecursive(sb, child, false, hideInInspector);

			// root class closes here - after recursion
			if (isRoot)
				CodeGenSnippets.Close(sb, classTabCount);
		}

		private static void GenerateChildComponentsFields(StringBuilder sb, int childrenCount,
			List<CodeGeneratorComponent> children, int fieldTabCount, bool hideInInspector = false)
		{
			for (var i = 0; i < childrenCount; i++)
			{
				if (i is not 0)
					CodeGenSnippets.AppendLine(sb);

				CodeGeneratorComponent child = children[i];
				CodeGenSnippets.CreateComponentField(sb, child.TypeName, child.Name, fieldTabCount, hideInInspector);
			}
		}

		private static void GenerateUnityComponentFields(StringBuilder sb, List<Component> components,
			int fieldTabCount, bool hideInInspector = false)
		{
			for (var i = 0; i < components.Count; i++)
			{
				if (i is not 0)
					CodeGenSnippets.AppendLine(sb);

				Component component = components[i];
				CodeGenSnippets.CreateComponentField(sb, component.GetType(), fieldTabCount, hideInInspector);
			}
		}

		private void InitializeComponentsRecursive(CodeGeneratorComponent root, Transform transform)
		{
			foreach (Component component in transform.GetComponents<Component>())
				root.UnityComponents.Add(component);

			int childCount = transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform childTransform = transform.GetChild(i);
				string safeTransformName = childTransform.name.CropBeforeRestrictedCharacters();
				var childComponent =
					new CodeGeneratorComponent(safeTransformName,
						$"{root.TypeName}{_settings.InnerClassSeparator}{safeTransformName}");
				root.Children.Add(childComponent);
				InitializeComponentsRecursive(childComponent, childTransform);
			}
		}
	}
}
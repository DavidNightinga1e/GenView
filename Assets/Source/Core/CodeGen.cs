using System;
using System.IO;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace GenView.Core
{
	public static class CodeGen
	{
		public static void ProcessAssistant(ViewGenerationAssistant assistant)
		{
			FileDescription fileDescription = CreateFileDescription(assistant);

			var sb = new StringBuilder();
			Generate(sb, fileDescription);

			string directory = assistant.OutputDirectory;
			string fileName = assistant.OutputClassName;
			string filePath = Path.Combine(Application.dataPath, directory, fileName + ".cs");
			
			if (File.Exists(filePath)) 
				File.Delete(filePath);

			using var writer = new StreamWriter(filePath);
			writer.Write(sb.ToString());
			writer.Close();
		}

		private static FileDescription CreateFileDescription(ViewGenerationAssistant assistant)
		{
			var description = new FileDescription
			{
				ClassName = assistant.OutputClassName,
				ClassNamespace = assistant.OutputNamespace
			};

			var root = new CodeGeneratorComponent(assistant.OutputClassName);
			description.Root = root;
			InitializeComponentsRecursive(root, assistant.transform);

			return description;
		}

		public static void SerializeComponentReferences(ViewGenerationAssistant assistant, Type type, object instance)
		{
			FieldInfo fieldInfo = type.GetField("_rectTransform", BindingFlags.NonPublic | BindingFlags.Instance);
			fieldInfo.SetValue(instance, (RectTransform)assistant.transform);
		}

		private static void SerializeRecursive(CodeGeneratorComponent codeGeneratorComponent, object instance)
		{
			var unityComponents = codeGeneratorComponent.UnityComponents;
			// Type.GetType(codeGeneratorComponent.Name) full name? 
		}

		private static void Generate(StringBuilder sb, FileDescription fileDescription)
		{
			CodeGenSnippets.AddFileSummary(sb);
			CodeGenSnippets.CreateNamespace(sb, fileDescription.ClassNamespace);

			GenerateRecursive(sb, fileDescription.Root, string.Empty);

			CodeGenSnippets.Close(sb, 0);
		}

		private static void GenerateRecursive(StringBuilder sb, CodeGeneratorComponent root, string parentClassName)
		{
			string selfName;
			bool isRoot;
			if (string.IsNullOrEmpty(parentClassName))
			{
				selfName = root.Name;
				isRoot = true;
			}
			else
			{
				selfName = parentClassName + "_" + root.Name;
				isRoot = false;
			}

			var classTabCount = isRoot ? 1 : 2;
			int fieldTabCount = classTabCount + 1;
			
			if (!isRoot)
				CodeGenSnippets.AppendLine(sb);
			
			CodeGenSnippets.CreateClass(sb, selfName, classTabCount, isRoot);

			var children = root.Children;
			var components = root.UnityComponents;

			for (var i = 0; i < components.Count; i++)
			{
				if (i is not 0)
					CodeGenSnippets.AppendLine(sb);
				
				Component component = components[i];
				CodeGenSnippets.CreateComponentField(sb, component.GetType(), fieldTabCount);
			}

			int childrenCount = children.Count;
			if (childrenCount is not 0)
				CodeGenSnippets.AppendLine(sb);

			for (var i = 0; i < childrenCount; i++)
			{
				if (i is not 0) 
					CodeGenSnippets.AppendLine(sb);

				CodeGeneratorComponent child = children[i];
				string componentNameWithParent = selfName + "_" + child.Name;
				CodeGenSnippets.CreateComponentField(sb, componentNameWithParent, child.Name, fieldTabCount);
			}

			if (!isRoot)
				CodeGenSnippets.Close(sb, classTabCount);

			foreach (CodeGeneratorComponent child in children)
			{
				GenerateRecursive(sb, child, selfName);
			}

			if (isRoot)
				CodeGenSnippets.Close(sb, classTabCount);
		}

		private static void InitializeComponentsRecursive(CodeGeneratorComponent root, Transform transform)
		{
			foreach (Component component in transform.GetComponents<Component>())
				root.UnityComponents.Add(component);

			int childCount = transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform childTransform = transform.GetChild(i);
				string safeTransformName = childTransform.name.CropBeforeRestrictedCharacters();
				var childComponent = new CodeGeneratorComponent(safeTransformName);
				root.Children.Add(childComponent);
				InitializeComponentsRecursive(childComponent, childTransform);
			}
		}
	}
}
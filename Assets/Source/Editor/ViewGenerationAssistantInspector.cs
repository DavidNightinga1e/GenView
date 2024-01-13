using System;
using System.IO;
using GenView;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;

namespace GenViewEditor
{
	[CustomEditor(typeof(ViewGenerationAssistant))]
	public class ViewGenerationAssistantInspector : Editor
	{
		private SerializedProperty _outputDirectory;
		private SerializedProperty _outputNamespace;
		private SerializedProperty _outputClassName;
		private SerializedProperty _assemblyName;

		private void OnEnable()
		{
			_outputDirectory = serializedObject.FindProperty("OutputDirectory");
			_outputNamespace = serializedObject.FindProperty("OutputNamespace");
			_outputClassName = serializedObject.FindProperty("OutputClassName");
			_assemblyName = serializedObject.FindProperty("AssemblyName");
		}

		public override void OnInspectorGUI()
		{
			serializedObject.Update();
			EditorGUILayout.PropertyField(_outputDirectory);
			EditorGUILayout.PropertyField(_outputNamespace);
			EditorGUILayout.PropertyField(_outputClassName);
			EditorGUILayout.PropertyField(_assemblyName);
			serializedObject.ApplyModifiedProperties();

			if (GUILayout.Button("Generate C# View"))
				Generate();

			if (GUILayout.Button("Add Component"))
				AddComponent();

			if (GUILayout.Button("Remove Component"))
				RemoveComponent();

			if (GUILayout.Button("Delete File"))
				DeleteFile();
		}

		private void Generate()
		{
			string path = CodeGenUtilities.GetPathToFile(
				_outputDirectory.stringValue,
				_outputClassName.stringValue);
			string type = CodeGenUtilities.TypeCombine(
				_outputNamespace.stringValue,
				_outputClassName.stringValue,
				_assemblyName.stringValue);

			string mainMessage = $"[Path] {path}\n" +
			                     $"[Type] {type}";

			bool exists = File.Exists(path);

			mainMessage += exists
				? $"\n\nFile EXISTS! Press OK to overwrite"
				: $"\n\nPress OK to generate";

			bool response = EditorUtility.DisplayDialog("GenView", mainMessage, "OK", "Cancel");
			if (!response)
				return;

			var codeGen = new CodeGen();
			codeGen.GenerateFile((ViewGenerationAssistant)serializedObject.targetObject);

			AssetDatabase.Refresh();
			CompilationPipeline.RequestScriptCompilation();
		}

		private void DeleteFile()
		{
			string path = CodeGenUtilities.GetPathToFile(
				_outputDirectory.stringValue,
				_outputClassName.stringValue);

			if (File.Exists(path))
			{
				bool response = EditorUtility.DisplayDialog("GenView", "Delete file?", "Yes", "Cancel");
				if (response)
				{
					File.Delete(path);

					AssetDatabase.Refresh();
					CompilationPipeline.RequestScriptCompilation();
				}
			}
			else
			{
				EditorUtility.DisplayDialog("GenView", "File not found", "OK");
			}
		}

		private void AddComponent()
		{
			var codeGen = new CodeGen();
			codeGen.AddComponentAndSerializeReferences((ViewGenerationAssistant)serializedObject.targetObject);
		}

		private void RemoveComponent()
		{
			string typeName = CodeGenUtilities.TypeCombine(
				_outputNamespace.stringValue,
				_outputClassName.stringValue,
				_assemblyName.stringValue);
			var type = Type.GetType(typeName);
			if (type == null)
			{
				EditorUtility.DisplayDialog("GenView", "Type not found. Remove component manually", "OK");
				return;
			}

			Component component =
				((ViewGenerationAssistant)serializedObject.targetObject).gameObject.GetComponent(type);
			if (component == null)
			{
				EditorUtility.DisplayDialog("GenView", "Component not found", "OK");
				return;
			}

			DestroyImmediate(component);
		}
	}
}
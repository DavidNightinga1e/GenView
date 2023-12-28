using System;
using GenView.Example;
using UnityEngine;

namespace GenView.Core
{
	public class ViewGenerationAssistant : MonoBehaviour
	{
		public string OutputDirectory;
		public string OutputNamespace;
		public string OutputClassName;

		private Type Type => Type.GetType(OutputNamespace + "." + OutputClassName); 
		
		[ContextMenu("Generate")]
		public void Generate()
		{
			CodeGen.ProcessAssistant(this);
			UnityEditor.AssetDatabase.Refresh();
			
			UnityEditor.Compilation.CompilationPipeline.RequestScriptCompilation();
		}

		[ContextMenu("Add Component")]
		public void AddComponent()
		{
			gameObject.AddComponent(Type);
		}

		[ContextMenu("Serialize References")]
		public void SerializeReferences()
		{
			CodeGen.SerializeComponentReferences(this, Type, GetComponent(Type));
		}

		[ContextMenu("Delete File")]
		public void DeleteFile()
		{
			
		}
	}
}
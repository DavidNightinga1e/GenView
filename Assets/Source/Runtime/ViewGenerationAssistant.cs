using JetBrains.Annotations;
using UnityEngine;

namespace GenView
{
	public class ViewGenerationAssistant : MonoBehaviour
	{
		public string OutputDirectory;
		public string OutputNamespace;
		public string OutputClassName;
		[UsedImplicitly] public string AssemblyName;
	}
}
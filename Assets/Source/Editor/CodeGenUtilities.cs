using System.IO;
using UnityEngine;

namespace GenViewEditor
{
	public static class CodeGenUtilities
	{
		public static string GetPathToFile(string directory, string className)
		{
			return Path.Combine(Application.dataPath, directory, className + ".cs");
		}

		public static string TypeCombine(string classNamespace, string className, string assemblyName)
		{
			if (string.IsNullOrWhiteSpace(assemblyName))
				assemblyName = "Assembly-CSharp";
			return $"{classNamespace}.{className}, {assemblyName}";
		}
		
		public static string TypeCombine(string classNamespace, string parentClass, string innerClass, string assemblyName)
		{
			if (string.IsNullOrWhiteSpace(assemblyName))
				assemblyName = "Assembly-CSharp";
			return $"{classNamespace}.{parentClass}+{innerClass}, {assemblyName}";
		}
	}
}
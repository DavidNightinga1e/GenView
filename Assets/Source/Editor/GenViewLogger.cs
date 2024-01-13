using UnityEngine;

namespace GenViewEditor
{
	public static class GenViewLogger
	{
		public static void Log(string log)
		{
			Debug.Log($"[GenView] {log}");
		}	
		
		public static void LogError(string log)
		{
			Debug.LogError($"[GenView] {log}");
		}
	}
}
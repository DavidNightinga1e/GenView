using UnityEngine;

namespace GenView.Core
{
	public static class GenViewLogger
	{
		public static void Log(string log)
		{
			Debug.Log($"[GenView] {log}");
		}
	}
}
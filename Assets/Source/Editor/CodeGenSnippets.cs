using System;
using System.Text;

namespace GenViewEditor
{
	public static class CodeGenSnippets
	{
		public static void CreateComponentField(StringBuilder sb, Type componentType, int tabCount, bool hideInInspector)
		{
			string typeFullName = componentType.FullName;
			string name = componentType.Name;
			CreateComponentField(sb, typeFullName, name, tabCount, hideInInspector);
		}

		public static void CreateComponentField(StringBuilder sb, string componentType, string name, int tabCount, bool hideInInspector)
		{
			PushTabs(sb, tabCount);
			string field = name.ToPrivateField();
			string attributes = hideInInspector
				? "[UnityEngine.SerializeField]"
				: "[UnityEngine.SerializeField, UnityEngine.HideInInspector]";
				
			sb.AppendLine($"{attributes} private {componentType} {field};");
			PushTabs(sb, tabCount);
			sb.AppendLine($"public {componentType} {name.ToPublicProperty()} => {field};");
		}

		public static void AppendLine(StringBuilder sb)
		{
			sb.AppendLine();
		}

		public static void CreateClass(StringBuilder sb, string className, int tabCount, bool isRootClass = false)
		{
			PushTabs(sb, tabCount);
			if (!isRootClass)
			{
				sb.AppendLine("[System.Serializable]");
				PushTabs(sb, tabCount);
			}
			sb.AppendLine(isRootClass
				? $"public class {className} : GenView.GeneratedView"
				: $"public class {className}");
			PushTabs(sb, tabCount);
			sb.AppendLine("{");
		}

		public static void Close(StringBuilder sb, int tabCount)
		{
			PushTabs(sb, tabCount);
			sb.AppendLine("}");
		}

		public static void AddFileSummary(StringBuilder sb)
		{
			sb.AppendLine("// Warning: This file is code-generated");
			sb.AppendLine("// Modifying it can lead to data-loss");
			sb.AppendLine("// ------------------------------------");
			sb.AppendLine("// Generated using GenView by David Nightingale");
			sb.AppendLine("// https://github.com/DavidNightinga1e");
			sb.AppendLine("\n// ReSharper disable InconsistentNaming");
			sb.AppendLine();
		}
		
		public static void CreateNamespace(StringBuilder sb, string namespaceText)
		{
			sb.AppendLine($"namespace {namespaceText}");
			sb.AppendLine("{");
		}

		private static void PushTabs(StringBuilder sb, int tabCount)
		{
			for (int i = 0; i < tabCount; i++)
				sb.Append("\t");
		}

		public static string ToPrivateField(this string name)
		{
			if (char.IsLower(name, 0))
				return "_" + name;

			return "_" + char.ToLowerInvariant(name[0]) + name[1..];
		}

		public static string ToPublicProperty(this string name)
		{
			if (char.IsUpper(name, 0))
				return name;

			return char.ToUpperInvariant(name[0]) + name[1..];
		}

		public static string CropBeforeRestrictedCharacters(this string name)
		{
			for (var i = 0; i < name.Length; i++)
			{
				if (!char.IsLetterOrDigit(name, i) && name[i] != '_')
					return name[..i];
			}

			return name;
		}
	}
}
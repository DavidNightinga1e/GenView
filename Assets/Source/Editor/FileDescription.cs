using GenView;

namespace GenViewEditor
{
	public class FileDescription
	{
		public string ClassNamespace { get; }
		public string ClassName { get; }
		public string AssemblyName { get; }
		public CodeGeneratorComponent Root { get; }

		public FileDescription(string classNamespace, string className, string assemblyName, CodeGeneratorComponent root)
		{
			ClassNamespace = classNamespace;
			ClassName = className;
			AssemblyName = assemblyName;
			Root = root;
		}

		public FileDescription(ViewGenerationAssistant assistant, CodeGeneratorComponent root) : this(
			assistant.OutputNamespace,
			assistant.OutputClassName,
			assistant.AssemblyName,
			root)
		{
		}
	}
}
using System.Collections.Generic;
using UnityEngine;

namespace GenViewEditor
{
	/// <summary>
	/// From scene hierarchy perspective each CodeGeneratorComponent is a GameObject.
	/// UnityComponents are components attached. Children are children GOs
	/// Name is GO's name
	///
	/// From View's code perspective CodeGeneratorComponent is a class that
	/// represent node in internal hierarchy.
	/// UnityComponents are fields of actual component type
	/// Children are fields of child type.
	/// Name is used as field identifier in parent class.
	/// TypeName is exactly name of this class. 
	/// </summary>
	public class CodeGeneratorComponent
	{
		public string Name { get; }
		public string TypeName { get; }
		public List<Component> UnityComponents { get; }
		public List<CodeGeneratorComponent> Children { get; }

		public CodeGeneratorComponent(string name, string typeName)
		{
			Name = name;
			TypeName = typeName;
			UnityComponents = new List<Component>();
			Children = new List<CodeGeneratorComponent>();
		}
	}
}
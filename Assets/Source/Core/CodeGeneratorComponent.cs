using System;
using System.Collections.Generic;
using UnityEngine;

namespace GenView.Core
{
	public class CodeGeneratorComponent
	{
		public string Name { get; private set; }
		public List<Component> UnityComponents { get; private set; }
		public List<CodeGeneratorComponent> Children { get; private set; }

		public CodeGeneratorComponent(string name)
		{
			Name = name;
			UnityComponents = new List<Component>();
			Children = new List<CodeGeneratorComponent>();
		}
	}
}
using UnityEngine;

namespace GenView
{
	[CreateAssetMenu(menuName = "GenView/Create settings file")]
	public class GenViewSettings : ScriptableObject
	{
		[SerializeField] private string innerClassSeparator;
		[SerializeField] private bool hideInInspector;

		public string InnerClassSeparator => innerClassSeparator;
		public bool HideInInspector => hideInInspector;
	}
}
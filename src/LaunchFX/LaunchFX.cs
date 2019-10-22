using System;
using System.IO;
using UnityEngine;

/**********************************************************
 * TODO:
 * todo: add module to tanks
 **********************************************************/

namespace LaunchFX
{
	class LaunchFX : PartModule
	{
		public static string ConfigPath = "GameData/LaunchFX/settings.cfg";
		private static readonly string _assemblyPath = Path.GetDirectoryName(typeof(LaunchFX).Assembly.Location);
		internal static String SettingsFile { get; } = Path.Combine(_assemblyPath, "pSettings.cfg");
		internal static String LogFile { get; } = Path.Combine(_assemblyPath, "cfx.log");

		public static string AssemblyPath => _assemblyPath;

		public LaunchFX()
		{
		}

		public void Start()
		{
			this.
		}
	}

		public static void DumpScene(GameObject go)
		{

			string filename = @"F:\modding\unity\unity-scene.json";

			//Debug.Log("Dumping scene to " + filename + " ...");
			using (StreamWriter writer = new StreamWriter(filename, false))
			{
			//	foreach (GameObject gameObject in Selection.gameObjects)
			//	{
					DumpGameObject(go, writer, "");
					//writer.WriteLine(gameObject.GetType().Name + ": " + EditorJsonUtility.ToJson(gameObject));
			}
			//}
			//Debug.Log("Scene dumped to " + filename);
		}

		private static void DumpGameObject(GameObject gameObject, StreamWriter writer, string indent)
		{
			writer.WriteLine("{0}+{1}", indent, gameObject.name);

			foreach (Component component in gameObject.GetComponents<Component>())
			{
				DumpComponent(component, writer, indent + "  ");
			}

			foreach (Transform child in gameObject.transform)
			{
				DumpGameObject(child.gameObject, writer, indent + "  ");
			}
		}

		private static void DumpComponent(Component component, StreamWriter writer, string indent)
		{
			writer.WriteLine("{0}{1}", indent, (component == null ? "(null)" : component.GetType().Name));
			writer.WriteLine("\t{0}\n", JsonUtility.ToJson(component));
			//writer.WriteLine("\t{0}\n\n", EditorJsonUtility.ToJson(component));
		}
	}

}

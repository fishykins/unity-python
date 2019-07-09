using UnityEngine;

namespace Exodrifter.UnityPython.Examples
{
	public class PythonUnityHelloWorld : MonoBehaviour
	{
		void Start()
		{
			var engine = UnityPython.CreateEngine(new string[] {"UnityEngine"});
			var scope = engine.CreateScope();

			string code = "import UnityEngine\nUnityEngine.Debug.Log('Hello world!')";

			var source = engine.CreateScriptSourceFromString(code);
			source.Execute(scope);
		}
	}
}
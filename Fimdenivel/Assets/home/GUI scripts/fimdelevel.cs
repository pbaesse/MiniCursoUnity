using UnityEngine;
using System.Collections;

public class fimdelevel : MonoBehaviour {
	void OnGUI(){

		GUILayout.BeginArea (new Rect (200, 200, 200, 200));
		GUILayout.BeginHorizontal ();
		GUILayout.Label ("Seu tempo foi: "+" segundos");
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();

		GUILayout.BeginArea (new Rect (1000, 500, 200, 400));
		GUILayout.BeginHorizontal ();
		if (GUILayout.Button ("Nivel 2")) {
			Application.LoadLevel("");
			Debug.Log("jogandu");
		}
		if (GUILayout.Button ("Repetir Nivel")) {
			Application.LoadLevel("");
			Debug.Log("jogandu2");
		}
		if (GUILayout.Button ("sair")) {
			Application.Quit();
		}
		
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();    
		

	}
}
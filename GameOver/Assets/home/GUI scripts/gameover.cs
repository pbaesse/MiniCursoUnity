using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {
	void OnGUI(){
		GUILayout.BeginArea (new Rect (700, 350, 200, 400));
		GUILayout.BeginVertical ();
		//GUI.Box (new Rect (0,0,400,50), "");
		if (GUILayout.Button ("Tentar Novamente")) {
			Application.LoadLevel("");
			Debug.Log("jogandu");
		}
		if (GUILayout.Button ("Sair")) {
			Application.Quit ();
		}
		
		GUILayout.EndVertical ();
		GUILayout.EndArea ();    
		

	}
}



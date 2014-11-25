using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {
	string level = controlador_de_level.get_ultimoLevel();
	void OnGUI(){
		GUILayout.BeginArea (new Rect (700, 350, 200, 400));
		GUILayout.BeginVertical ();
		//GUI.Box (new Rect (0,0,400,50), "");

		if (GUILayout.Button ("Tentar Novamente")) {
			if(level== "level1" ){
				Application.LoadLevel(level);
			}
			if(level == "level2"){

				Application.LoadLevel(level);	

			}
		}
		
		if (GUILayout.Button ("Menu")) {
			Application.LoadLevel("Menu");
		}
		if (GUILayout.Button ("Sair")) {
			Application.Quit();
		}
		GUILayout.EndVertical ();
		GUILayout.EndArea ();    
		

	}
}



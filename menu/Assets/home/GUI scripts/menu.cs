using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public bool showOptions = false;
	public bool showCredits = false;
	private int guiButtonWidth = 100;
	// Use this for initialization

	/*
		var Count = 30;

		function Update()
		{
		if (BotaoAcao.comecou == true) {
		Count = Count - Time.time;
		print(Count);
		} 
		}
	 */
	//public Texture t;
	void OnGUI(){
		/*GUI.Box (new Rect(300,350,Screen.width/2 -130,Screen.height/2 -130),"");
		GUI.Button (new Rect (100, 100,Screen.width / 2 - 100, Screen.height / 2 - 100), "Start Game");
		*/
		GUILayout.BeginArea (new Rect (0, 0, 200, 300));
		GUILayout.BeginVertical ();
		if (GUILayout.Button ("Start Game")) {
			Application.LoadLevel ("");
			Debug.Log("Clicked the image");
		}
		if (GUILayout.Button ("Options")) {
			showOptions = true;
		}
		if (GUILayout.Button ("Credits")) {
			showCredits = true;
		}
		if (GUILayout.Button ("Quit Game")) {
			Application.Quit ();
		}
		
		GUILayout.EndVertical ();
		GUILayout.EndArea ();    
		
		if (showOptions) {
			showOptions = true;
			
			GUILayout.BeginArea (new Rect (210, 0, 200, 300));
			GUILayout.BeginHorizontal ();
			//text column
			GUILayout.Label ("Quality settings", GUILayout.Width (100));
			GUILayout.EndHorizontal ();
			//settings column
			GUILayout.BeginHorizontal ();
			GUILayout.Button ("Fastest");
			GUILayout.Button ("Fast");
			GUILayout.Button ("Simple");
			GUILayout.Button ("Good");
			GUILayout.Button ("Beautiful");
			GUILayout.Button ("Fantastic");
			GUILayout.EndHorizontal ();
			GUILayout.EndArea ();
		} else {
			showOptions = false;
		}
		if (showCredits) {
			showCredits = true;
			GUILayout.BeginArea (new Rect (210, 0, 200, 300));
			GUILayout.BeginHorizontal ();
			GUILayout.Button ("You did it");
			GUILayout.EndHorizontal ();
			GUILayout.EndArea ();
		} else {
			showCredits = false;
		}
	}



}
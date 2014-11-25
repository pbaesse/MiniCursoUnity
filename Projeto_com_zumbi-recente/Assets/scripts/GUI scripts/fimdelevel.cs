using UnityEngine;
using System.Collections;

public class fimdelevel : MonoBehaviour {
	static Contador cont = new Contador();
	float seg = Mathf.Round(Contador.segundos_gastos);

	void OnGUI(){
		if(seg <10)
			GameObject.Find("Tempo").guiText.text = "Seu tempo foi: 0"  + seg.ToString();
		if(seg >10)
			GameObject.Find("Tempo").guiText.text = "Seu tempo foi: "  + seg.ToString();
		GUILayout.BeginArea (new Rect (1000, 500, 200, 400));
		GUILayout.BeginHorizontal ();
		if (GUILayout.Button ("Nivel 2")) {
			Application.LoadLevel("level2");
			Debug.Log("jogandu");
		}
		if (GUILayout.Button ("Level 1")) {
			Application.LoadLevel("Level1");
			Debug.Log("jogandu2");
		}
		if (GUILayout.Button ("sair")) {
			Application.Quit();
		}
		
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();    
		

	}
}
using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public bool Nivel = false;
	public bool Creditos = false;
	private int botaoAltura = 100;
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
		GUILayout.BeginArea (new Rect (400, 200, 200, 400));
		GUILayout.BeginVertical ();
		if (GUILayout.Button ("Iniciar Jogo")) {
			Nivel = false;
			Creditos = false;
			//Application.LoadLevel ("nome da sena");
			//descomente a linha acima e apague a linha abaixo
			Debug.Log("jogandu");
			//a linha acima e so pra testar a funcionalidade do botaum...
		}
		if (GUILayout.Button ("Escolher nivel")) {
			Nivel = true;
			Creditos = false;
		}
		if (GUILayout.Button ("Creditos")) {
			Creditos = true;
			Nivel = false;
		}
		if (GUILayout.Button ("Sair")) {
			Creditos = false;
			Nivel = false;
			Application.Quit ();
		}
		
		GUILayout.EndVertical ();
		GUILayout.EndArea ();    
		
		if (Nivel) {
			Nivel = true;
			GUILayout.BeginArea (new Rect (410, 400, 200, 400));
			GUILayout.BeginHorizontal ();
			//text column
			GUILayout.Label ("Escolher Nivel", GUILayout.Width (100));
			GUILayout.EndHorizontal ();
			//settings column
			GUILayout.BeginHorizontal ();
			if(GUILayout.Button ("Nivel 1")){
				//Application.LoadLevel ("nome sena nivel 1");
				//descomente a linha acima e apague a linha abaixo
				print("nivel 1");
			}

			if (GUILayout.Button ("Nivel 2")){
				//Application.LoadLevel ("nome sena nivel 2");
				//descomente a linha acima e apague a linha abaixo
				print("nivel 2");
			}
			GUILayout.EndHorizontal ();
			GUILayout.EndArea ();
		} 
		if (Creditos) {
			Creditos = true;
			GUILayout.BeginArea (new Rect (410, 400, 200, 400));
			GUILayout.BeginHorizontal ();
			GUILayout.Label ("Joguinho feito por Odailton gordo,thyago laskadu e Bruno Invisible");
			GUILayout.EndHorizontal ();
			GUILayout.EndArea ();
		}
	}
}



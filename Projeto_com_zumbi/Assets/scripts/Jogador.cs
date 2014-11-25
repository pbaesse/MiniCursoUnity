using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	GUIStyle gui = new GUIStyle ();
	int moedas = 0;
	bool morreu = false;
	string level;
	static Contador cont = new Contador();
	void Start () {
		controlador_de_level.set_ultimoLevel(Application.loadedLevelName);
		level = controlador_de_level.get_ultimoLevel();
		Debug.Log (moedas.ToString());
	}
	
	// Update is called once per frame
	void Update () {

		if(moedas == 4)
			Application.LoadLevel("fimdelevel");
		if(Input.GetKey(KeyCode.Escape))
			Application.LoadLevel("Menu");
		if (morreu && !audio.isPlaying) 
			Application.LoadLevel("gameover");
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Moeda") 
		{
			moedas++;
			Debug.Log (moedas);
		}
		if (c.tag == "monstro") 
		{
			controlador_de_level.set_ultimoLevel(Application.loadedLevelName);
			audio.Play();
			morreu = true;
		}
		
	}

	void OnGUI() {
	{

		gui.fontSize = 26;
		gui.fontStyle = FontStyle.Bold;
		gui.normal.textColor = Color.white;


	}
  }
}

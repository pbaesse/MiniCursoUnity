using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	GUIStyle gui = new GUIStyle ();
	int moedas = 0;	
	string level;
	static Contador cont = new Contador();
	void Start () {
		controlador_de_level.set_ultimoLevel(Application.loadedLevelName);
		level = controlador_de_level.get_ultimoLevel();
		Debug.Log (moedas.ToString());
	}
	
	// Update is called once per frame
	void Update () {

		if(moedas == 2)
			Application.LoadLevel("fimdelevel");
		if(Input.GetKey(KeyCode.Escape))
			Application.LoadLevel("Menu");
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
			//audio.PlayOneShot(grito, 1f);
			Application.LoadLevel("gameover");
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

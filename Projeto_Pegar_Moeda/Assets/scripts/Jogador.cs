using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	GUIStyle gui = new GUIStyle ();
	int moedas = 0;
	void Start () {
		Debug.Log (moedas.ToString());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Moeda") 
		{
			moedas++;
			Debug.Log (moedas);
		}
		
		
	}

	void OnGUI()
	{
		GUI.contentColor = Color.white;
		gui.fontSize = 26;
		gui.fontStyle = FontStyle.Bold;
		gui.normal.textColor = Color.white;

		GUI.TextArea(new Rect(10, 10, 200, 30), "");
		GUI.Label (new Rect (13, 10, 200, 50), "Moedas: " + moedas, gui);
	}
}

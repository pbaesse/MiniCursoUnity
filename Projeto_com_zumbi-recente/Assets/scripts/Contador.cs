using UnityEngine;
using System.Collections;

public class Contador : MonoBehaviour 
{
	static public float Segundos = 0;
	float segundos_regressivos;
	static public float segundos_gastos;
	
	string level ;
	void Start(){
		controlador_de_level.set_ultimoLevel(Application.loadedLevelName);
		level = controlador_de_level.get_ultimoLevel();
		Debug.Log(level);
		if(level== "level1" ){
			Segundos = 180;
		}
		if(level== "level2" ){
			Segundos = 240;
		}
	}
	void Update()
	{
		// This is if statement checks how many seconds there are to decide what to do.
		// If there are more than 0 seconds it will continue to countdown.
		// If not then it will reset the amount of seconds to 59 and handle the minutes;
		// Handling the minutes is very similar to handling the seconds.
		
		segundos_gastos = Mathf.Round(Time.timeSinceLevelLoad);
		segundos_regressivos = Segundos - segundos_gastos;
		GameObject.Find("TimerText").guiText.text = segundos_regressivos.ToString();

			
			
	}
}
			

using UnityEngine;
using System.Collections;

public class Contador : MonoBehaviour 
{
 	static public float Segundos = 0; 
	 static public float Minutos = 0;
	static public float Segundos_inicial = 0; 
	static public float Minutos_inicial = 0;
	string level ;
	void Start(){
		controlador_de_level.set_ultimoLevel(Application.loadedLevelName);
		level = controlador_de_level.get_ultimoLevel();
		Debug.Log(level);
		if(level== "level1" ){
			Minutos = 1;
			Segundos = 20;
			Segundos_inicial = Segundos;
			Minutos_inicial = Minutos;
		}
		if(level== "level2" ){
			Minutos = 2;
			Segundos = 0;
			Segundos_inicial = Minutos;
			Minutos_inicial = Segundos;

		}
	}
		void Update()
	{
		// This is if statement checks how many seconds there are to decide what to do.
		// If there are more than 0 seconds it will continue to countdown.
		// If not then it will reset the amount of seconds to 59 and handle the minutes;
		// Handling the minutes is very similar to handling the seconds.
	
			Debug.Log(Time.timeSinceLevelLoad);
		if(Segundos <= 0)
		{
			Segundos = 59;
			if(Minutos >= 1)
			{
				Minutos--;
			}
			else
			{
				Minutos = 0;
				Segundos = 0;
				// This makes the guiText show the time as X:XX. ToString.("f0") formats it so there is no decimal place.
				//GameObject.Find("TimerText").guiText.text = Minutos.ToString() + ":0" + Segundos.ToString();
				controlador_de_level.set_ultimoLevel(Application.loadedLevelName);
				Application.LoadLevel("gameover");
			}
		}
		else
		{
			Segundos -= Time.deltaTime;
		}
		
		// These lines will make sure the time is shown as X:XX and not X:XX.XXXXXX
		if(Mathf.Round(Segundos) <= 9)
		{
			GameObject.Find("TimerText").guiText.text = Minutos.ToString("f0") + ":0" + Segundos.ToString("f0");
		}
		else
		{
			GameObject.Find("TimerText").guiText.text = Minutos.ToString("f0") + ":" + Segundos.ToString("f0");
		}
	 }
}
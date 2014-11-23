using UnityEngine;
using System.Collections;

public static class controlador_de_level  {

	private static string lastLevel;
	
	public static void set_ultimoLevel(string level)
	{
		lastLevel = level;
	}
	
	public static string get_ultimoLevel()
	{
		return lastLevel;
	}
	
	public static void mudar_para_o_anterior()
	{
		Application.LoadLevel(lastLevel);
	}
}

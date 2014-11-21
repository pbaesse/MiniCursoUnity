using UnityEngine;
using System.Collections;

public class RotaçãoMoeda : MonoBehaviour {
	
	
	public AudioClip a;
	int incremento_z = 3;
	void Start () {
		//gameObject.particleSystem.enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		int z = 3;
		transform.Rotate (0, 0, z);
		z += incremento_z;
	
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") 
		{
			incremento_z = 12;
			audio.clip = a;
			audio.Play(44100);
			yield return new WaitForSeconds(audio.clip.length);
			Destroy (gameObject);

	    }


	}

}

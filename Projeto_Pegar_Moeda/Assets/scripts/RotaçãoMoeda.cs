using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class RotaçãoMoeda : MonoBehaviour {
	
	
	float z = 3;
	bool destruido = false;
	void Start () {
		//gameObject.particleSystem.enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, z);
		if (destruido && !audio.isPlaying)Destroy (gameObject);
	
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") 
		{
			z = 18;
			Destroy(GetComponent<MeshCollider>());
			audio.Play();
			destruido = true;
	    }


	}

}

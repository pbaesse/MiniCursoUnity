using UnityEngine;

using System.Collections;

public class encontra : MonoBehaviour {
	GameObject a ;
	NavMeshAgent agente; 
	// Use this for initialization
	Vector3 other;
	void Start () {
		agente = GetComponent<NavMeshAgent>();
	}
	// Update is called once per frame
	void Update () {
		other = GameObject.FindGameObjectWithTag("Player").transform.position;
		float dist = Vector3.Distance(other, transform.position);
//		Debug.Log("Distance to other: " + dist);
		if(dist <= 13)		{
	
			agente.SetDestination(other);
			animation.Play("andando");
		}
		else if(dist > 13){
			agente.Stop();
			animation.Play ("parado");
		}
	
	}
}


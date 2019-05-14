using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Object has fallen off the stage");
		if(other.GetComponent<Rigidbody>() != null)
		{
			Debug.Log("This is sandbag"); 
			other.GetComponent<Rigidbody>().velocity = Vector3.zero;
			other.transform.position = new Vector3(0, 5, 0);
		}
		else
		{
			//other.GetComponent<CharacterController>().velocity = Vector3.zero;
			other.transform.position = new Vector3(0, 5, 0);
		}
		

	}
}

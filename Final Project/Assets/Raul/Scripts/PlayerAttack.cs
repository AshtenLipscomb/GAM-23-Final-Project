using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {


	public float pushBack = 20; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Object entered trigger");
	}

	void OnTriggerStay(Collider other)
	{
		Debug.Log("Object is within the trigger");
		other.GetComponent<Rigidbody>().AddForce(new Vector3(5, 5, 0) * pushBack, ForceMode.Acceleration); 

	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log("Object has exited trigger");
	}
}

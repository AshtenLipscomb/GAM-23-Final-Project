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

	void OnTriggerEnter(Collider collision)
	{
		Debug.Log("Test"); 
		collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(5, 5, 0) * pushBack, ForceMode.Acceleration);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour {

	//public GameObject rightSpawn;
	//public GameObject leftSpawn; 

	public Rigidbody arrow;
	public float speed = 4;
	//public bool fireArrow = true; 

	// Use this for initialization
	void Start () {
		Instantiate(arrow, new Vector3(0, 0, 0), Quaternion.identity); 
	}
	
	// Update is called once per frame
	void Update () {
		
			if (Input.GetKeyDown("Fire1"))
		{
			Debug.Log("Arrow");
			Rigidbody a = Instantiate(arrow, transform.position, transform.rotation);
			a.velocity = transform.forward * speed; 
			
		}
			 
		
	}

	

	


}

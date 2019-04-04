using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization


	public float speed = 6.0f;
	public float jumpSpeed = 15.0f;
	public float gravity = 20.0f;

	private CharacterController controller;

	private float verticalVelocity = 0;

	public Rigidbody rocket;

	void Start ()
	{
		controller = GetComponent<CharacterController>();	
	}

	void FireRocket()
	{
		Rigidbody rocketClone = (Rigidbody)Instantiate(rocket, transform.position, transform.rotation);
		rocketClone.velocity = transform.forward * speed;

		// You can also access other components / scripts of the clone
		//rocketClone.GetComponent<MyRocketScript>().DoSomething();
	}

	// Update is called once per frame
	void Update ()
	{
		if (controller.isGrounded)
		{
			if (Input.GetButton("Jump"))
			{
				verticalVelocity = jumpSpeed;
			}
			else
			{
				verticalVelocity = 0;
			}
		}
		else
		{
			verticalVelocity -= gravity * Time.deltaTime;
		}
		Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal") * speed, verticalVelocity, 0.0f);
		moveDirection = transform.TransformDirection(moveDirection);
		controller.Move(moveDirection * Time.deltaTime);

		if (Input.GetButton("Fire1"))
		{
			FireRocket();
			Debug.Log("Attacking");
		}

	}

	
}

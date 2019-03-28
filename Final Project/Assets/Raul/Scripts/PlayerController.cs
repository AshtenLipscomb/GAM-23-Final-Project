using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization


	public float speed = 6.0f;
	public float jumpSpeed = 8.0f;
	public float gravity = 20.0f;

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller; 

	void Start ()
	{
		controller = GetComponent<CharacterController>();

		gameObject.transform.position = new Vector3(0, 5, 0); 	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (controller.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
			//Input.GetAxis("Vertical")
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection = moveDirection * speed; 
			
			if (Input.GetButton("Jump"))
			{
				moveDirection.y = jumpSpeed; 
			}
		}
		

		moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

		controller.Move(moveDirection * Time.deltaTime); 

	}
}

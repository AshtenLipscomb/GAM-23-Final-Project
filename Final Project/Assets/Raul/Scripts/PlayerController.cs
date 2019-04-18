using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization


	public float speed = 6.0f;
	public float jumpSpeed = 15.0f;
	public float gravity = 20.0f;
	public SpriteRenderer sprite;

	public GameObject rightHit;
	public GameObject leftHit;

	private CharacterController controller;

	private float verticalVelocity = 0;

	

	void Start ()
	{
		controller = GetComponent<CharacterController>();	
	}

	void punchLeft()
	{
		leftHit.SetActive(true);
		rightHit.SetActive(false); 
	}

	void punchRight()
	{
		leftHit.SetActive(false);
		rightHit.SetActive(true);
	}

	// Update is called once per frame
	void Update ()
	{
		leftHit.SetActive(false);
		rightHit.SetActive(false);
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

		if (Input.GetAxis("Horizontal") > 0)
		{
			sprite.flipX = false; 
		}
		else if(Input.GetAxis("Horizontal") < 0)
		{
			sprite.flipX = true;
		}

		if (Input.GetButton("Fire1"))
		{
			if (sprite.flipX)
			{
				punchLeft(); 
			}
			else
			{
				punchRight(); 
			}

			//other.GetComponent<Rigidbody>().AddForce(new Vector3(5, 5, 0) * pushBack, ForceMode.Acceleration);
		}



	}

	
}

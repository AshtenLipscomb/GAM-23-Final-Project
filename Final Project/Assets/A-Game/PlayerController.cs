using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 6.0f;
	public float jumpSpeed = 15.0f;
	public float gravity = 20.0f;
	public SpriteRenderer sprite;

	public GameObject rightHit;
	public GameObject leftHit;

	private CharacterController controller;

	private float verticalVelocity = 0;

    public int characterNum = 0;

    public string jumpButton1 = "Jump_P1", jumpButton2 = "Jump_P2";
    public string horizontalCtrl1 = "Horizontal_P1", horizontalCtrl2 = "Horizontal_P2";
    public string attackButton1 = "Fire1_P1", attackButton2 = "Fire2_P2";

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

        if(characterNum == 1)
        {
            if (controller.isGrounded)
            {
                if (Input.GetButton(jumpButton1))
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
            Vector3 moveDirection = new Vector3(Input.GetAxis(horizontalCtrl1) * speed, verticalVelocity, 0.0f);
            moveDirection = transform.TransformDirection(moveDirection);
            controller.Move(moveDirection * Time.deltaTime);

            if (Input.GetAxis(horizontalCtrl1) > 0)
            {
                sprite.flipX = false;
            }
            else if (Input.GetAxis(horizontalCtrl1) < 0)
            {
                sprite.flipX = true;
            }

            if (Input.GetButton(attackButton1))
            {
                if (sprite.flipX)
                {
                    punchLeft();
                }
                else
                {
                    punchRight();
                }
            }
        }
        else if(characterNum == 2)
        {
            if (controller.isGrounded)
            {
                if (Input.GetButton(jumpButton2))
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
            Vector3 moveDirection = new Vector3(Input.GetAxis(horizontalCtrl1) * speed, verticalVelocity, 0.0f);
            moveDirection = transform.TransformDirection(moveDirection);
            controller.Move(moveDirection * Time.deltaTime);

            if (Input.GetAxis(horizontalCtrl2) > 0)
            {
                sprite.flipX = false;
            }
            else if (Input.GetAxis(horizontalCtrl2) < 0)
            {
                sprite.flipX = true;
            }

            if (Input.GetButton(attackButton2))
            {
                if (sprite.flipX)
                {
                    punchLeft();
                }
                else
                {
                    punchRight();
                }
            }
        }
	}
}

//other.GetComponent<Rigidbody>().AddForce(new Vector3(5, 5, 0) * pushBack, ForceMode.Acceleration);
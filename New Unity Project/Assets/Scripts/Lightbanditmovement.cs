using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbanditmovement : MonoBehaviour
{

	public float movSpeed = 5f; //sets the variable of movSpeed to the value of 5
	Rigidbody2D rb; //setting the rigidbody 2d to a variable to make it easier to use in my code
	float speedx, speedy;
	// Use this for initialization
	private SpriteRenderer spriteRenderer; //declares a private variable called SpriteRenderer

	void Start()
	{
		rb = GetComponent<Rigidbody2D>(); //allows my sprite to access and manipulate the way physics will act on the sprite. For example gravity
		spriteRenderer = GetComponent<SpriteRenderer>();//renders the sprite asset on screen using the position, rotation and scale


	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float direction = Input.GetAxisRaw("Horizontal"); //retrieves the value of the horizontal axis and then stores it as a float


		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))//checks to see if the user has inputed WASD and if it has it will initiate what is in the below
		{
			speedx = Input.GetAxisRaw("Horizontal") * movSpeed; //calculates the horizontal speed from the WASD input
			speedy = Input.GetAxisRaw("Vertical") * movSpeed; //calculates the vertical speed from the WASD input
			rb.velocity = new Vector2(speedx, speedy); //sets the velocity of a 2D object using the speedx and speedy
		}
		else
		{
				rb.velocity = new Vector2(0, 0); //sets the velocity to 0,0 when it isnt moving( 0 speed, 0 direction)
		}
		if (direction > 0) // if the user is pressing D as the vector will be greater than 0 

		{ 

			spriteRenderer.flipX = true; //change the way the sprite is facing 

		} 

		else if (direction < 0) //if the user is pressing A as the vector will be less than 0  

		{ 

			spriteRenderer.flipX = false; //change the way the sprite is moving 

		} 
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour 
{
	private SpriteRenderer spriteRenderer;
	public float movSpeed; // setting the movement speed to 3
	public string direction; // setting the direction of the enemy
	// Use this for initialization
	
	void Start()
	{

			direction = "right"; // setting the direction to thee right
			movSpeed = 1f; //setting movement speed to the right
			spriteRenderer = GetComponent<SpriteRenderer>(); //gets the spriteRenderer components currently ticked etc
	}
		
		
	private void OnTriggerEnter2D(Collider2D other)  //for when colliding with the empty objects
	{

		if(other.gameObject.tag == "leftMarker") //when the enemy sprite hits the leftMarker
		{
			direction = "right"; //sets direction to the right after hitting the leftMarker
		
		}
		else if (other.gameObject.tag == "rightMarker") //when the enemy sprite hits the rightMarker
		{
			
			direction = "left"; //changes the direction to the left

		}
	}
	// Update is called once per frame
	void Update () 
	{

		if ( direction == "right") //if the direction is right
		{

			transform.Translate(Vector3.right * Time.deltaTime * movSpeed); //each frame moves the enemy sprite to the left
		
		}
		
		else if ( direction == "left") //if the direction is left
		{

			transform.Translate(Vector3.left * Time.deltaTime * movSpeed); //each frame moves the enemy sprite to the right
			
		
		}

			if (direction ==  "left")
		{
			spriteRenderer.flipX = true;
		}
		else if (direction == "right")
		{
			spriteRenderer.flipX = false;
		}
	}
}



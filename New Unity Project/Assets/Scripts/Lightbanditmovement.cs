using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbanditmovement : MonoBehaviour
{

	public float movSpeed = 5f;
	Rigidbody2D rb;
	float speedx, speedy;
	// Use this for initialization
	private SpriteRenderer spriteRenderer;


	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();


	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float direction = Input.GetAxisRaw ("Horizontal");

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D)) {
			speedx = Input.GetAxisRaw ("Horizontal") * movSpeed;
			speedy = Input.GetAxisRaw ("Vertical") * movSpeed;
			rb.velocity = new Vector2 (speedx, speedy);
		} else {
			rb.velocity = new Vector2 (0, 0);
		}

		if (direction > 0) {
			spriteRenderer.flipX = true;
		} else if (direction < 0) {
			spriteRenderer.flipX = false;
		}
	}
		public void Speed(int speedAmount) //making new function to change the speed of my lightbandit
		{
			movSpeed += speedAmount; //will change the players speed by the speedAmount 
		} 

  	public IEnumerator decreaseSpeed()
	{

	Speed(-2); //decrease players movement speed by 2
	Debug.Log ("Player's speed decreased"); //creates a debug to let me know if the players movement speed is being decreased

	yield return new WaitForSeconds (5f);
	//pauses code for 5 seconds

	Speed(2); //adds 2 to the speed
	Debug.Log ("Player's speed returned to normal"); //displays in the console that speed is returned to normal
	}
}
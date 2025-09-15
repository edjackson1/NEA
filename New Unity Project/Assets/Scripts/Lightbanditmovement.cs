using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbanditmovement : MonoBehaviour
{

	public float movSpeed = 5f;
	Rigidbody2D rb;
	float speedx, speedy;
	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();


	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
		{
			speedx = Input.GetAxisRaw("Horizontal") * movSpeed;
			speedy = Input.GetAxisRaw("Vertical") * movSpeed;
			rb.velocity = new Vector2(speedx, speedy);
		}
		else
		{
			rb.velocity = new Vector2(0, 0); 
		}
	}
}

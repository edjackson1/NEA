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
		float direction = Input.GetAxisRaw("Horizontal");

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

		if (direction > 0)
		{
			spriteRenderer.flipX = true;
		}
		else if (direction < 0)
		{
			spriteRenderer.flipX = false;
		}
	}
}

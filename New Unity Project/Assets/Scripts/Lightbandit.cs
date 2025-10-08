using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbandit : MonoBehaviour
{
	//declare a new atribute of the data type 'Animator'
	Animator MyAnimator;



	// Use this for initialization
	//connect attribute with our characters animator
	void Start()
	{
		MyAnimator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		//when key D is pressed, run will be set to true
		if (Input.GetKey(KeyCode.W) ||
			Input.GetKey(KeyCode.A) ||
			Input.GetKey(KeyCode.S) ||
			Input.GetKey(KeyCode.D))
		{
			MyAnimator.SetBool("run", true);
		}
		else
		{
			MyAnimator.SetBool("run", false);
		}
		
		if(Input.GetKey(KeyCode.Mouse0))
		{
			MyAnimator.SetBool("attack", true);
		}
		else
		{
			MyAnimator.SetBool("attack", false);
		}

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Enemy enemyComponent = collision.gameObject.GetComponent<Enemy>();
		if(enemyComponent != null)
		{
			enemyComponent.TakeDamage(1);
		}
	}
	
	

}
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
		
		if(Input.GetKey(KeyCode.Mouse0)) //when left click is pressed
		{
			MyAnimator.SetBool("attack", true); //play the attack animation 
		}
		else
		{
			MyAnimator.SetBool("attack", false); //don't play attack animation 
		}

	}

	private void OnCollisionEnter2D(Collision2D collision) // creating a new void for when my sprite collides with the object
	{
		Enemy enemyComponent = collision.gameObject.GetComponent<Enemy>(); //it retrieves the script from the Enemy script
		if(enemyComponent != null) //if the enemy component is not equal to null
		{
			enemyComponent.TakeDamage(1); // the enemy will take 1 damage
		}
	}
	
	

}
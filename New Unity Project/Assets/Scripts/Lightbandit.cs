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
			MyAnimator.Play("attack"); //play the attack animation 
		}

	}
		private Enemy enemyComponent;
	 	private void OnCollisionEnter2D(Collision2D collision)//creating a new void for when my sprite collides with the object
		{
			enemyComponent = collision.gameObject.GetComponent<Enemy>();//checking if the enemy has a script
		} 
	
	
		public void DamageEnemy() //so it can be used on the animation timeline
	{
				if(enemyComponent != null) //if the enemy component is not equal to null
					{
						enemyComponent.TakeDamage(1); // the enemy will take 1 damage
						Debug.Log("Enemy took damage"); //will show a debug message if the enemy is taking damage
						enemyComponent = null; //stops the enemy from taking damage more than once
					}
	}

}


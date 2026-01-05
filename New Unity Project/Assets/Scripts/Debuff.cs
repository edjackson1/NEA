using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff : MonoBehaviour {
public Lightbanditmovement LBM;
	// Use this for initialization


	private void OnTriggerEnter2D(Collider2D collision) //will cause a trigger when colliding with the debuff
	{
		if (collision.CompareTag ("Player")) //if the gameObject with the tag "Player collides"
		{ 
			Lightbanditmovement LightBandit = collision.GetComponent<Lightbanditmovement> (); //allows the code to be reached from the LightBanditmovement script
			LightBandit.StartCoroutine (LightBandit.decreaseSpeed ()); //starts the coroutine called decreaseSpeed
			Destroy (gameObject); //destroys the debuff preventing it from being used again
		}
	}
		
}


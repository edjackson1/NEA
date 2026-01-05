using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff : MonoBehaviour {
public Lightbanditmovement LBM;
	// Use this for initialization


	private void OnTriggerEnter2D(Collider2D collision) //will cause a trigger when colliding with the debuff
	{
		if (collision.CompareTag ("Player")) { //if the gameObject with the tag "Player collides"
			LBM.Speed(-2); //decrease players movement speed by 2
			Debug.Log ("Player's speed decreased"); //creates a debug to let me know if the players movement speed is being decreased
			Destroy (gameObject); //will destroy the debuff so it can not be used more than once.


		}
	}
}

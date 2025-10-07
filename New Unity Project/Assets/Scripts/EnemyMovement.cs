using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour {

	public float movSpeed = 5f; // setting the movement speed to 5
	string direction; // setting the direction of the enemy
	// Use this for initialization
	
	private void OnTriggerEnter2d(Collider2D other) {

		if(other.gameObject.tag == "leftMarker")
		{
			direction = "right";
		}
	}
		
		
	
	// Update is called once per frame
	void Update () {

		if( direction == "right"){

			transform.Translate(Vector3.right * Time.deltaTime * movSpeed);
		
		}
		
	}
}


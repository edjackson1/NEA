using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour {
public LightBanditHealth LBH;

		private void OnTriggerEnter2D(Collider2D collision) //will cause a trigger when colliding with the heart
		{
			if(collision.CompareTag("Player")) //if the gameObject with the tag "Player collides"
			{
				LBH.Heal(1); //heal player by 1 (add 1 onto health)
				Debug.Log("Player Healed"); //write that the player healed in the console
				Destroy(gameObject); //destroys the heart so can't be used more than once 
			}
		}
}

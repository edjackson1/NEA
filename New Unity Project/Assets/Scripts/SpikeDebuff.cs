using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDebuff : MonoBehaviour {
public LightBanditHealth LBH;

		private void OnTriggerEnter2D(Collider2D collision) //will cause a trigger when colliding with the heart
		{
			if(collision.CompareTag("Player")) //if the gameObject with the tag "Player collides"
			{
				LBH.Damage(5); //damage player by 5 (add 5 onto health)
				Debug.Log("Player Damaged"); //write that the player healed in the console
			}
		}
}

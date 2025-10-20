using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBanditHealth : MonoBehaviour {
	
	[SerializeField] int playerHealth, maximumHealth = 5;

	
	void Start(){
		playerHealth = maximumHealth;
	}
	// Update is called once per frame
	public void TakeDamage(int damageAmount)
	{
		playerHealth -= damageAmount;

		if (playerHealth <= 0) {
			Destroy (gameObject);
		}
	}
	void Update () {
		
	}
}

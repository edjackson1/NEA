using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightBanditHealth : MonoBehaviour {
	
	public int playerHealth, maximumHealth = 5;

	
	void Start()
	{
		playerHealth = maximumHealth;
	}
	// Update is called once per frame
	public void TakeDamage(int damageAmount)
	{
		playerHealth -= damageAmount;

		if (playerHealth <= 0) {
			Destroy (gameObject);
			SceneManager.LoadSceneAsync("EndScreen");
		}
	}
	
	public void Heal(int healAmount) //making new function to add health to my lightbandit
	{
		playerHealth += healAmount; //will heal the player health by the healAmount 
	}
}

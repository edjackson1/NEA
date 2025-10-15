using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	[SerializeField] int health, maxHealth = 3;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}

	public void TakeDamage(int damageAmount)
	{
		health -= damageAmount;

		if(health <= 0)
		{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

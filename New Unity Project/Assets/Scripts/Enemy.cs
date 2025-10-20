using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	[SerializeField] int health, maxHealth = 3;
	[SerializeField] EnemyHealth healthBar;
	public int damage;
	public LightBanditHealth LBH;
	// Use this for initialization

	private void Health()
	{
		healthBar = GetComponentInChildren<EnemyHealth> ();
	}


	void Start () {
		health = maxHealth;
		healthBar.HealthBar(health, maxHealth);
	}

	public void TakeDamage(int damageAmount)
	{
		healthBar.HealthBar(health, maxHealth);
		health -= damageAmount;
		if(health <= 0)
		{
			Destroy(gameObject);
		}
	}
	
	public void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Player")
		{
			LBH.TakeDamage(damage);
		}
	}
}
	
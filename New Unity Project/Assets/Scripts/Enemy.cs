using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	[SerializeField] int health, maxHealth = 3;
	[SerializeField] EnemyHealth healthBar;
	public int damage;
	public LightBanditHealth LBH;
	public bool damagePlayer = false;
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
	
	private void OnCollisionEnter2D(Collision2D collision)
		{
			if(collision.gameObject.CompareTag ("Player") && damagePlayer)
			if(LBH != null)
				{
					LBH.TakeDamage(1);
					Debug.Log("Player took damage");
				}
		}
	
	public void damagePlayerOn()
	{
		damagePlayer = true;
	}

	public void damagePlayerOff()
	{
		damagePlayer = false;
	}

}
	
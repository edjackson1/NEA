using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public TextMeshPro Health;
	[SerializeField] int health, maxHealth = 5;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	public void TakeDamage(int damageAmount)
	{
		health -= damageAmount;

		if (health <= 0) {
			Destroy (gameObject);
		}
	}
	void Update () {
		
	}
}

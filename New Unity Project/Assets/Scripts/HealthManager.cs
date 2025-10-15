using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
	public Image healthBar;
	public float healthAmount = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse0))
		{
			TakeDamage(1);
		}
	}

	public void TakeDamage(float damage)
	{
		healthAmount -= damage;
		healthBar.fillAmount = healthAmount / 3f;
	}

}

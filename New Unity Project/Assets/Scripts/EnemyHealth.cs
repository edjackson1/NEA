using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	[SerializeField] private Slider slider;
	public void HealthBar(float currentValue, float maxValue)
	{
		slider.value = currentValue / maxValue;
	}
	// Update is called once per frame
	void Update () {
		
	}
}

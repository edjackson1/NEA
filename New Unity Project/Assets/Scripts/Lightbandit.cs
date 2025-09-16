using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
=======
public class Lightbandit : MonoBehaviour {
	//declare a new atribute of the data type 'Animator'
	Animator MyAnimator;


	// Use this for initialization
	//connect attribute with our characters animator
	void Start() {
		MyAnimator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update() {
		//when key D is pressed, run will be set to true
			if (Input.GetKey(KeyCode.W) || 
				Input.GetKey(KeyCode.A) ||
				Input.GetKey(KeyCode.S) ||
				Input.GetKey(KeyCode.D)) 
		{
			MyAnimator.SetBool("run", true);
		}
		else
		{
			MyAnimator.SetBool("run", false);
		}

		

		
	}
}
>>>>>>> 125d6ad238aa2dc1e8ee94f057cee799b81fe5be

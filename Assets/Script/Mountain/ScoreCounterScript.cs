using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounterScript : MonoBehaviour {



	void Awake(){
	

	}
	void OnTriggerEnter2D(Collider2D target) {

		if (target.tag == "Player") { 

		
			ScoreCountScript.counter += 1;

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainScript : MonoBehaviour {

	public float move_Speed = 3f;
	public float bound_X = -22f;



	private Animator anim;

	void Awake() {
		
	}

	void Update() {
		Move();
	}

	void Move() {

		Vector2 temp = transform.position;
		temp.x -= move_Speed * Time.deltaTime;
		transform.position = temp;

		if(temp.x <= bound_X) {
			gameObject.SetActive(false);
		}

	} // move



 void OnCollisionEnter2D(Collision2D target) {
     if(target.gameObject.tag == "Player") { 
			GameManager.instance.RestartGame(0f);
	 }
	 
 }



} // class


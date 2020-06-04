using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {
	private Rigidbody2D myBody;

	public float moveSpeed = 20f;

	void Awake() {
		myBody = GetComponent<Rigidbody2D>();
	}

	void Update() {
		
		Move();
		
	 Vector2 moveDirection = myBody.velocity;
         if (moveDirection != Vector2.zero) {
			  float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
			 if(moveDirection.y>0){
            
             transform.rotation = Quaternion.AngleAxis(angle-10, Vector3.forward);
			 }else{
				 transform.rotation = Quaternion.AngleAxis(angle+10, Vector3.forward);
			 }
         }

	}

	void Move() {

		if(Input.GetKeyDown("space")||Input.GetMouseButtonDown(0)) {
			//myBody.velocity = new Vector2(myBody.velocity.x,moveSpeed );
				myBody.AddForce(new Vector2(0, 15), ForceMode2D.Impulse);
		}





	} // move





}

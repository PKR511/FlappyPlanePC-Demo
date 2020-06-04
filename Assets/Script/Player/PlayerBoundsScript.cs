using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundsScript : MonoBehaviour {

    public float  max_y = 7.0f, min_Y = -7.0f;
    private bool out_Of_Bounds;

    void Update() {
        CheckBounds();
    }

    void CheckBounds() {

        Vector2 temp = transform.position;

        if (temp.y > max_y)
            temp.y = max_y;
		

        transform.position = temp;

		if(temp.y <= min_Y ) { 

            if(!out_Of_Bounds) {

                out_Of_Bounds = true;

                
                 GameManager.instance.RestartGame(2f);

            }

        }

    } // check bounds

   

} // class





































using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    void Awake() {
		
        if (instance == null)
            instance = this;
    }


   

	public void RestartGame(float time) {
		Invoke("RestarteAfterTime", time);
	}

    void RestarteAfterTime() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes-001");
    }



	 
} // class




































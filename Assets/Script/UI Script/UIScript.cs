using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {


	public 	void StartGame () {
		SceneManager.LoadScene("Scenes-001");
	}

	public 	void OpenMainMenu () {
		SceneManager.LoadScene("Menu Scene");
	}


}

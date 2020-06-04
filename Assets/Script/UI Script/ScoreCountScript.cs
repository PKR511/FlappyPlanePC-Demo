using UnityEngine;
using UnityEngine.UI;

public class ScoreCountScript : MonoBehaviour {

	public static int scoreValue = 0;
	public static int counter;
	Text value1,value2;
	void Awake () {
		value1 = GameObject.Find("ScoreValue").GetComponent<Text>();
		value2 = GameObject.Find("BestValue").GetComponent<Text>();	
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
			value1.text = "" + counter;
		if (scoreValue < counter)
			scoreValue = counter;
			value2.text = "" + scoreValue;
		
	}


}

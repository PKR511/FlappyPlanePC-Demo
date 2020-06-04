using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainSpawner : MonoBehaviour {
	
	public GameObject mountainPrefab;


	public float mountain_Spawn_Timer = 2f;
	private float current_mountain_Spawn_Timer;



	public int min_Y = 3, max_Y = 5;


	// Start is called before the first frame update
	void Start() {
		current_mountain_Spawn_Timer = mountain_Spawn_Timer;
	}

	// Update is called once per frame
	void Update() {
		SpawnPlatforms();
	}

	void SpawnPlatforms() {

		current_mountain_Spawn_Timer += Time.deltaTime;

		if(current_mountain_Spawn_Timer >= mountain_Spawn_Timer) {

			Vector3 temp = transform.position;
			temp.y = Random.Range(min_Y, max_Y);


			GameObject newPlatform = null;
			newPlatform = Instantiate(mountainPrefab, temp,Quaternion.identity );



			newPlatform.transform.parent = transform;


			current_mountain_Spawn_Timer = 0f;

		} // spawn platform

	}


} // class


























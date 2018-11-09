using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour {


public ScoreAndGameOver GameOver;
public GameObject[] Obstacles;
public float SpawnStartDelay;
public float SpawnDelay;

	// Use this for initialization
	void Start () {
		StartCoroutine(spawnObstacles());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator spawnObstacles(){
		yield return new WaitForSeconds(SpawnStartDelay);
		while(true){
			//Vector3 spawnposition = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0));
			//spawnposition.y = gameObject.transform.position.y;
			//spawnposition.z = 0;
			Vector3 spawnposition = gameObject.transform.position;
			int index = Random.Range(0,Obstacles.Length);
			Instantiate(Obstacles[index], spawnposition, Quaternion.Euler(0,0,0));
			print("spawn");
			yield return new WaitForSeconds(SpawnDelay);
		} 
	}

	}	

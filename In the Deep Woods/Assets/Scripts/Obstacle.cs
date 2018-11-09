using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

public float speed;

Vector3 startposition;

private float x;



	// Use this for initialization
	void Start () {
		startposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		x += Time.deltaTime * speed;
		transform.position = startposition - new Vector3(x, 0, 0);
	}
}

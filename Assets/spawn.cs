using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
	public GameObject car;
	public float maxPos=2.43f;
	public float delayTimer=1f;
	float timer;

	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPos = new Vector3 (Random.Range (-2.43f, 2.43f), transform.position.y, transform.position.z);

			Instantiate (car, carPos, transform.rotation);
			timer = delayTimer;
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehavior : MonoBehaviour {
	public float xDisplace, yDisplace, zDisplace;
	public float count = 0, target;
	Vector3 movement;

	public bool xForwards = true;

	float xStart, yStart, zStart;

	// Use this for initialization
	void Start () {

		xStart = transform.position.x;
		yStart = transform.position.y;
		zStart = transform.position.z;
		movement = new Vector3 (xDisplace, yDisplace, zDisplace);
	}
	
	// Update is called once per frame
	void Update () {

		if (xForwards) {
			transform.position += movement;
			if (transform.position.x >= (target+xStart)) {
				xForwards = false;
			}
		} else {
			transform.position -= movement;
			if (transform.position.x < xStart) {
				xForwards = true;
			}
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandBehavior : MonoBehaviour {
	public Rigidbody[] islands = new Rigidbody[5];
	public float[] xPosTriggers = new float[5];

	public GameObject player;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<Transform> ().position.x > -40) {
			islands [0].isKinematic = false;
			islands [0].useGravity = true;
		}
	}
}

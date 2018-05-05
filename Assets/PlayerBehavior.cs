using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
	public Rigidbody RB;
	public static int force;


	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			RB.AddForce (force, 0, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			RB.AddForce (0, -force, 0);

		}
		if (Input.GetKey (KeyCode.W)) {
			RB.AddForce (0, force, 0);

		}
		if (Input.GetKey (KeyCode.D)) {
			RB.AddForce (-force, 0, 0);
		}
	}
}

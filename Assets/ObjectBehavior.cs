using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {
	public Rigidbody RB;
	public BoxCollider BC;
	public GameObject GO;


	// Use this for initialization
	void Start () {
		RB.isKinematic = true;
		RB.useGravity = false;
	}

	void OnTriggerStay(Collider coll){
		Debug.Log ("Triggered");

		if ( RB.isKinematic ){//coll.gameObject.tag == "Player") {//
			if (Input.GetMouseButtonUp (0)) {
				Debug.Log ("Player");
				RB.isKinematic = false;
				RB.useGravity = true;
				GO = coll.gameObject;
			}
		} else if (coll.gameObject.tag != "Player") {
			Debug.Log (coll.gameObject.name);
		}
	}
}

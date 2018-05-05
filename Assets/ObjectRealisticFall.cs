using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRealisticFall : MonoBehaviour {
	public float FallTime;
	public WaitForSeconds wait;
	public Rigidbody RB;

	// Use this for initialization
	void Start () {
		//RB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collider coll){
		if(coll.CompareTag("Player")){
		RB.isKinematic = false;
		RB.useGravity = true;
		}
	}
	void OnCollisionExit(Collider coll){
		if (coll.CompareTag ("Player")) {
			StartCoroutine (fallTimer ());
		}
	}

	IEnumerator fallTimer(){
		int count = 0;
		while (count < 1) {
			yield return wait;
		}
		RB.isKinematic = true;
		RB.useGravity = false;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour {

	private SteamVR_TrackedObject trackedObj;
	// 1
	private GameObject collidingObject; 
	// 2
	private GameObject objectInHand; 

	/*
	private SteamVR_Controller.Device Controller
	{
		get { return SteamVR_Controller.Input((int)trackedObj.index); }

	}*/

	void Awake()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void Update(){
		// 1
		//if (Controller.GetHairTriggerDown())
		if (Input.GetMouseButtonDown(0))
		{
			if (collidingObject)
			{
				GrabObject();
			}
				if (objectInHand)
				{
					ReleaseObject();
				}

		}

		// 2
		//if (Controller.GetHairTriggerUp())
		if (Input.GetMouseButtonUp(0))
			
		{
			if (objectInHand)
			{
				ReleaseObject();
			}
		}
	}
	private void SetCollidingObject(Collider col)
	{
		// 1
		if (collidingObject || !col.gameObject.GetComponent<Rigidbody>())
		{
			return;
		}
		// 2
		collidingObject = col.gameObject;
	}

	// 1
	public void OnTriggerEnter(Collider other)
	{
		//if (other.gameObject.tag == "Interactable") {
			SetCollidingObject (other);

		//Debug.Log (other.name);
		//}
	}

	// 2
	public void OnTriggerStay(Collider other)
	{
		//if (other.gameObject.tag == "Interactable") {
			SetCollidingObject (other);
		//}
	}

	// 3
	public void OnTriggerExit(Collider other)
	{
		if (!collidingObject)
		{
			return;
		}

		collidingObject = null;
	}
	private void GrabObject()
	{
		// 1
		objectInHand = collidingObject;
		collidingObject = null;
		// 2
		var joint = AddFixedJoint();
		joint.connectedBody = objectInHand.GetComponent<Rigidbody>();
	}

	// 3
	private FixedJoint AddFixedJoint()
	{
		FixedJoint fx = gameObject.AddComponent<FixedJoint>();
		fx.breakForce = 20000;
		fx.breakTorque = 20000;
		return fx;
	}

	private void ReleaseObject()
	{
		// 1
		if (GetComponent<FixedJoint>())
		{
			// 2
			GetComponent<FixedJoint>().connectedBody = null;
			Destroy(GetComponent<FixedJoint>());
			// 3
		//	objectInHand.GetComponent<Rigidbody>().velocity = Controller.velocity;
		//	objectInHand.GetComponent<Rigidbody>().angularVelocity = Controller.angularVelocity;
		}
		// 4
		objectInHand = null;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour {
	public Material day, night, dusk;
	public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.transform.position.y < -3.5) {
			RenderSettings.skybox = night;
		}

		if (Player.transform.position.y < -17.5) {
			RenderSettings.skybox = dusk;
		}

		if(Input.GetKey(KeyCode.Alpha1)){
			RenderSettings.skybox = night;
		}
		if(Input.GetKey(KeyCode.Alpha2)){
			RenderSettings.skybox = dusk;
		}

	}
}

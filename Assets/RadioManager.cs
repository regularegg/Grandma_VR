using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RadioManager : MonoBehaviour {
	public AudioClip[] songs = new AudioClip[5];	
	public AudioClip noise;
	public AudioSource radio;
	bool _end;
	bool end{
		get{ return _end; }
		set{
			if (!value) {
				radio.clip = noise;
			}
		}
	}

	void Start () {
		StartCoroutine (playSongs());
	}

	IEnumerator playSongs(){
		Debug.Log ("Started radio");
		for (int i = 0; i < songs.Length; i++) {
			radio.clip = songs [i];
			radio.Play ();
			Debug.Log (radio.isPlaying);
			yield return new WaitForSeconds (songs [i].length);
		}
	}
}

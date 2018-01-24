using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pig_down : MonoBehaviour {
	public static int score;
	public AudioSource audio;
	public Text score_text;

	// Use this for initialization
	void Start () {
		score = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.name=="floor") {
			audio.Play ();
			score += 10;
			score_text.text = "Score:" + score.ToString ();
		}
	}
}

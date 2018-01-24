using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdcontroll : MonoBehaviour {
	private float powerLevel;
	// Use this for initialization
	void Start () {
		powerLevel = 300f;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (1, 1, 0) * powerLevel);

		}
		if (Input.GetKey(KeyCode.Space)) {
				powerLevel += 50*Time.deltaTime;
				Debug.Log (powerLevel);
			}
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}

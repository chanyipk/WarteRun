using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypressed : MonoBehaviour {
	static public bool keypress;
	void Start () {
		keypress = false;
	
	}
	void Update () {// check every frame
		if (!keypress) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {//전진
				transform.position += new Vector3 (0, 0, 3f);
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {//좌이동
				transform.position -= new Vector3 (4f, 0, 0f);
				transform.position += new Vector3 (0f, 0, 3f);
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {//우이동
				transform.position += new Vector3 (4f, 0, 3f);
			}
			if (Input.GetKeyDown (KeyCode.Space)) {
				transform.position += new Vector3 (0, 0, 6f);
			}
		}
	} 
}

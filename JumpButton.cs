using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class JumpButton : MonoBehaviour {
	public float moveSpeed = 5;
	public float turnSpeed = 50f;
	public float jumpSpeed = 10;
	private bool leftButton;
	private bool rightButton;
	private bool upButton;
	private bool downButton;

	void Start(){
		leftButton = false;
		rightButton = false;
		upButton = false;
		downButton = false;
	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)||upButton == true)
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.DownArrow)||downButton == true)
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.LeftArrow) || leftButton == true)
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
		//transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow) || rightButton == true)
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
		//transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.Space))
			transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
	}

	public void Jump(){
		transform.Translate (Vector3.up * jumpSpeed * 0.5f);
	}
	public void ImageButtonDown(int i){
		switch (i) {
		case 1:
			leftButton = true;
			break;
		case 2:
			rightButton = true;
			break;
		case 3: upButton = true;
			break;
		case 4: downButton = true;
			break;
		}
	
	}
	public void ImageButtonUp(int i) {
		switch (i) {
		case 1: leftButton = false;
			break;
		case 2: rightButton = false;
			break;
		case 3: upButton = false;
			break;
		case 4: downButton = false;
			break;
		}
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public GameObject target;

	void Update(){
		float z = target.transform.position.z;
		float x = transform.position.x;
		float y = transform.position.y;
		transform.position = new Vector3(x,y,z-10f);
	}
}

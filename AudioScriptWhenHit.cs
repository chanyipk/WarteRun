using UnityEngine; 
using System.Collections;
public class AudioScriptWhenHit : MonoBehaviour {
	public AudioSource audio1;
	void OnCollisionEnter (Collision other) {
		if (other.gameObject.name=="pig") 
		{
			Debug.Log ("pig");
			audio1.Play ();
			//Destroy (gameObject); } }
		}
	}
}
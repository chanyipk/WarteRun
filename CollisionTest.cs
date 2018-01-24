using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class CollisionTest : MonoBehaviour {
	public Text mytext;
	private int score=0;
	void OnCollisionEnter() {
		Debug.Log ("Collision enter occurs");
		Update_Text ();
	}
	void Update_Text() {
		score += 1;
		mytext.text = "Collisions :" + score.ToString();
	}
}
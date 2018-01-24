using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CollisionStone : MonoBehaviour {
	public Text mytext;
	static public int score=-1;

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.CompareTag ("stone")) {
			Debug.Log ("stone");
			//scoreCase = 1;
			Update_Text ();
		}
	}

	void Update_Text() {
		score += 1;
		mytext.text = "Score : " + score.ToString();
	}

}

using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CollisionItem : MonoBehaviour {
	public Text Pointtext;
	static public int score = 0;
	void OnCollisionEnter(Collision other) {
		
		if (other.gameObject.CompareTag ("clock")) {
			Debug.Log ("clock");
			Update_Time ();
			Destroy (other.gameObject);
		}
		if (other.gameObject.CompareTag ("carrot")) {
			Debug.Log ("carrot");
			Update_Text ();
			Destroy (other.gameObject);
		}
		if (other.gameObject.CompareTag ("bomb")) {
			Update_Player ();
			Destroy (other.gameObject);
		}
	}
	void Update_Time(){
		float time = TimeCountDown.TimeCost += 3f;
		TimeCountDown.beforeTime = (int)time;
	}
	void Update_Text() {
		score += 10;
		Pointtext.text = "Plus Point : " + score.ToString();
	}
	void Update_Player(){
		
		transform.Rotate (-90f, 0f, 0f);
		Keypressed.keypress = true;
		Invoke ("Change_Keypressed", 3);	
	}
	void Change_Keypressed(){
		transform.Rotate (90f, 0f, 0f);
		Keypressed.keypress = false;
	}

}

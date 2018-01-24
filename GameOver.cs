using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class GameOver : MonoBehaviour {
	public GameObject target;
	public Text GameOverText;
	// Use this for initialization
	public bool gameover;
	// Update is called once per frame
	void Start(){
		gameover = false;
		GameOverText.text = "";
	}
	void Update () {
		float y = target.transform.position.y;
		if (!gameover && y < 0f) {
			Keypressed.keypress = true;
			TimeCountDown.TimeStop = true;
			GameOverText.text = "Game Over";
		}
	}
}

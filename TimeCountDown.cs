using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCountDown : MonoBehaviour {

	public Text TimeCount;
	static public float TimeCost;
	static public bool TimeStop;
	static public int beforeTime;
	public Text GameComplete;
	public Text CompleteScore;
	void Start(){
		TimeCost = 90f;
		beforeTime = (int)TimeCost;
		TimeStop = false;
	}
	void Update () {
		
		if (!TimeStop && TimeCost > 0f) {
			TimeCost -= Time.deltaTime;
			if (beforeTime - (int)TimeCost == 1) {
				if ((int)TimeCost % 60 < 10) {
					TimeCount.text = "Time " + (int)TimeCost / 60 + " : 0" + (int)TimeCost % 60;
				} else {
					TimeCount.text = "Time " + (int)TimeCost / 60 + " : " + (int)TimeCost % 60;

				}
				beforeTime = (int)TimeCost;
			}
		}
		else if((int)TimeCost == 0){
			int total = CollisionStone.score + CollisionItem.score;
			Keypressed.keypress = true;
			GameComplete.text = "Complete!";
			CompleteScore.text = "Score : " + CollisionStone.score + "\n"+ "Plus Score : " + CollisionItem.score + "\n" + "Total Score : " +total ;
			TimeStop = true;
		}
	}
}
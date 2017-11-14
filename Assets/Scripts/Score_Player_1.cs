using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Player_1 : MonoBehaviour {
	public Text Player_1_Score_Text;
	private int Player_1_Score;


	void Set_Player_1_Score (){
		Player_1_Score_Text.text = "Player 1 Score: " + Player_1_Score.ToString ();

	}
		
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag != "Ground")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
		Player_1_Score = Player_1_Score + 1;
		Set_Player_1_Score ();

	}
}

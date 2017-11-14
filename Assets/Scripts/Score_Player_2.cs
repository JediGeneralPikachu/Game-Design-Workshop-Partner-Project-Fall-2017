using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Player_2 : MonoBehaviour {
	public Text Player_2_Score_Text;
	private int Player_2_Score;


	void Set_Player_2_Score (){
		Player_2_Score_Text.text = "Player 1 Score: " + Player_2_Score.ToString ();

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Ground")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
		Player_2_Score = Player_2_Score + 1;
		Set_Player_2_Score ();

	}
}

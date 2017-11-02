using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
	private int score;
	public Text scoreText;

	void Start ()
	{
		score = 0;
		SetScoreText ();
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Ground")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
		score = score + 1;
		SetScoreText ();
	}
	void SetScoreText ()
	{
		scoreText.text = "score: " + score.ToString ();
	}
}
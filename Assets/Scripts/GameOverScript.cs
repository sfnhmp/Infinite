using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	public GameObject playerScore;
	int score = 0;
	 

	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		string pScore = score.ToString();
		playerScore.GetComponent<TextMesh> ().text = pScore;
	}


	

}

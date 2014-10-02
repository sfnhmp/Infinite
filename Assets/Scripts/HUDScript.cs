using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;
	public GameObject scoreText;
	int playerScoreToString;

	void Start(){
		//scoreText = scoreText.GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		playerScore += Time.deltaTime;
		playerScoreToString = (int)(playerScore * 10);
		string pScore = "SCORE: " + playerScoreToString.ToString();
		scoreText.GetComponent<TextMesh> ().text = pScore;
	}

	public void IncreaseScore(int amount){
		playerScore += amount;
	}

	void OnDisable(){
		PlayerPrefs.SetInt ("Score", (int)(playerScore * 10));
	}


	
}

















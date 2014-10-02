using UnityEngine;
using System.Collections;

public class HSOkScript : MonoBehaviour {

	public Camera cam;
	private HighScore highScore;

	void Start(){
		highScore = cam.GetComponent<HighScore>();

	}

	void OnMouseDown(){
		highScore.AddScore();

		Application.LoadLevel (4);
	}
}

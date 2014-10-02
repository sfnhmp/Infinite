using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class HighScore : MonoBehaviour {

	public int nameX = 15;
	public int nameHeight = 15;
	private bool guiOff = false;
	private bool playerNameCall = false;
	private int currentScore; 
	public string currentName = "___";
	List<ScoreManager> scores = new List<ScoreManager> ();

	// Use this for initialization
	void Start () {
		//List<ScoreManager> scores = new List<ScoreManager> ();

		scores.Add(new ScoreManager("JIM", 000));
		scores.Add (new ScoreManager ("BEN", 000));
		scores.Add (new ScoreManager ("KIP", 000));
		scores.Add (new ScoreManager ("ALI", 000));
		scores.Add (new ScoreManager ("NIL", 000));

		Debug.Log (scores.Count);

		//Get the players score from player prefs
		currentScore = PlayerPrefs.GetInt ("Score");
		//Get the data
		var data = PlayerPrefs.GetString("scores");
		//If not blank then load it
		if(!string.IsNullOrEmpty(data))
		{
			//Binary formatter for loading back
			var b = new BinaryFormatter();
			//Create a memory stream with the data
			var m = new MemoryStream(Convert.FromBase64String(data));
			//Load back the scores
			scores = (List<ScoreManager>)b.Deserialize(m);
		}

		// sort the scores
		scores.Sort ();

		

		
		/*foreach(ScoreManager scr in scores){
			print (scr.name + " " + scr.score);
		}
		*/
	
		if(currentScore > scores[4].score){
			playerNameCall = true;

		}
		else{
			Application.LoadLevel(2);
		}
		Debug.Log (scores.Count);
		//scores.RemoveRange (5, scores.Count);
	}

	void SaveScores()
	{
		//Get a binary formatter
		var b = new BinaryFormatter();
		//Create an in memory stream
		var m = new MemoryStream();
		//Save the scores
		b.Serialize(m, scores);
		//Add it to player prefs
		PlayerPrefs.SetString("scores",Convert.ToBase64String(m.GetBuffer()));
	}



	public void AddScore(){
		scores.Add(new ScoreManager(currentName, currentScore));
		scores.Sort ();
		scores.RemoveAt(5);
		//Debug.Log (scores.Count);
		foreach(ScoreManager scr in scores){
			print (scr.name + " " + scr.score);
		}
		SaveScores ();

	}

	void OnGUI(){
		if(playerNameCall){
			if(!guiOff){
				currentName = GUI.TextField(new Rect((Screen.width/2) - nameX,(Screen.height/2) - nameHeight, 100, 30), currentName, 3);

			}
		}
	}
	

}

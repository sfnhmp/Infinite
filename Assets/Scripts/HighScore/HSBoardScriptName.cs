using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class HSBoardScriptName : MonoBehaviour {

	public int index = 0;

	List<ScoreManager> scores = new List<ScoreManager> ();




	void Start () {
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
		
		scores.Sort ();


		GetComponent<TextMesh> ().text = scores [index].name;
	
	}
	

}

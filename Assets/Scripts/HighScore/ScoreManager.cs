using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



[Serializable]public class ScoreManager : IComparable<ScoreManager> {

	public string name;
	public int score;

	public ScoreManager(string newName, int newScore){
		name = newName;
		score = newScore;
	}

	//This method is required by the IComparable
	//interface. 
	public int CompareTo(ScoreManager other)
	{
		if(other == null)
		{
			return 1;
		}
		
		//Return the difference in power.
		return (score - other.score)  * -1;
	}

}

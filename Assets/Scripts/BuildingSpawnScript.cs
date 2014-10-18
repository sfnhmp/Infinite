using UnityEngine;
using System.Collections;

public class BuildingSpawnScript : MonoBehaviour {

	private float randomShade = 0.0f;
	
	void Start(){
		randomShade = Random.Range (0.36f, 1.0f);
		SpriteRenderer renderer = GetComponent<SpriteRenderer> ();
		renderer.color = new Color (randomShade, randomShade, randomShade, 1f);
	}
}

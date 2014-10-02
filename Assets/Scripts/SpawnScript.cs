using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1.0f;
	public float spawnMax = 2.0f;
	public int renderOrder = 0;
	private GameObject thisObj;

	void Start () {
		Spawn ();
	}
	
	void Spawn(){
		thisObj = Instantiate (obj [Random.Range (0, obj.GetLength (0))], transform.position, Quaternion.identity) as GameObject;
		thisObj.GetComponentInChildren<SpriteRenderer> ().sortingOrder = renderOrder;
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}

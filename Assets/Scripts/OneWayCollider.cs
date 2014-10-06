using UnityEngine;
using System.Collections;

public class OneWayCollider : MonoBehaviour {


	public Collider2D colls;


	void Start(){

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			colls.enabled = false;
			Debug.Log ("Collisions should be off");

		}
	}

	void OnTriggerExit2D(Collider2D other){
		if(other.tag == "Player"){
			colls.enabled = true;
			Debug.Log ("Collisiions should be back  on.");

		}
	}
}

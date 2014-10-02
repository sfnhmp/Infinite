using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public int health = 100;
	
	void Start () {

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "crow") {

			health -= other.GetComponent<CrowDamage>().damage;
			if(health <= 0){
				GetComponent<Platformer2DUserControl>().controls = false;
				Debug.Log ("DEAD MuthaFuck!");
			}
			Debug.Log (health);

		}
	}


}

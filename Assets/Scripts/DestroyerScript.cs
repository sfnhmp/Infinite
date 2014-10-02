using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			StartCoroutine(ChangeLevel());
			return;
		}

		if(other.gameObject.transform.parent){
			Destroy (other.gameObject.transform.parent.gameObject);
		}
		else{
			Destroy (other.gameObject);
		}
	}

	IEnumerator ChangeLevel(){
		float fadeTime = GameObject.Find ("_GM").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel(3);
	}
}

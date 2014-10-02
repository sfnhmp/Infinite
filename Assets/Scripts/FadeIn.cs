using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		StartCoroutine (FadeInto ());
	
	}
	
	IEnumerator FadeInto(){
		float fadeTime = GameObject.Find ("_GM").GetComponent<Fading> ().BeginFade (-1);
		yield return new WaitForSeconds (fadeTime);

	}
}

using UnityEngine;
using System.Collections;

public class MouseHoverScript : MonoBehaviour {

	public Color menuColor1;
	public Color menuColor2;
	public GameObject underLine;
	private Animator anim;

	void Start(){
		anim = GetComponent<Animator> ();
	}



	void OnMouseEnter(){
		GetComponent<TextMesh> ().fontStyle = FontStyle.Bold;
		GetComponent<TextMesh> ().color = menuColor1;
		underLine.SetActive(true) ;
		anim.SetBool ("MouseOver", true);

	}

	void OnMouseExit(){
		GetComponent<TextMesh> ().fontStyle = FontStyle.Normal;
		GetComponent<TextMesh> ().color = menuColor2;
		underLine.SetActive(false);
		anim.SetBool ("MouseOver", false);
	}


}

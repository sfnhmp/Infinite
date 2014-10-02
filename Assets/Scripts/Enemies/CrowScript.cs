using UnityEngine;
using System.Collections;

public class CrowScript : MonoBehaviour {


	public float speed = 20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * speed * Time.deltaTime);
	}
}

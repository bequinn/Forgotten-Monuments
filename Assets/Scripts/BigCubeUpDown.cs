using UnityEngine;
using System.Collections;

public class BigCubeUpDown : MonoBehaviour {

	Vector3 bigCubeStart; //this will remember where the cube started
	float distance = 0.08f;
	float shakeStrength = 14f;

	Vector3 camera;

	// Use this for initialization
	void Start () {
		bigCubeStart = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = bigCubeStart + new Vector3 (0, 1, 0) * Mathf.Sin (Time.time * 2);
	}

	void OnMouseEnter() {
		audio.Play ();
	}
	
	void OnMouseExit(){
		audio.Stop ();
	}
	
}

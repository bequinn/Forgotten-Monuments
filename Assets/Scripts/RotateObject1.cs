using UnityEngine;
using System.Collections;

public class RotateObject1 : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		transform.Rotate(new Vector3 (6, 0, 0));
		}

	void OnMouseEnter() {
		audio.Play ();
	}
	
	void OnMouseExit(){
		audio.Stop ();
	}
}

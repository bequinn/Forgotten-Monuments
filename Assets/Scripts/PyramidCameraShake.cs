using UnityEngine;
using System.Collections;

public class PyramidCameraShake : MonoBehaviour {

	float distance = 0.08f;
	float shakeStrength = 44f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void OnTriggerEnter(Collider other){
//		Camera.main.transform.position += new Vector3 (Mathf.Sin (Time.time * 30) * distance * shakeStrength, 0f, 0f); //acesses the camera
//	//	shakeStrength = Mathf.Clamp (shakeStrength - Time.deltaTime, 0f, 1f); //after 1 second, shake strength will go to from 1 to 0
//		//clamp function keeps it between 1 and 0	
//	}
	
}


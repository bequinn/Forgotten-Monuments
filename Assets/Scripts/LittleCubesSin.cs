using UnityEngine;
using System.Collections;

public class LittleCubesSin : MonoBehaviour {

	Vector3 littleCubesPosition;

	// Use this for initialization
	void Start () {
	
		littleCubesPosition = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = littleCubesPosition + new Vector3 (1, 0, 1) * Mathf.Sin (Time.time * 20);

	}
}

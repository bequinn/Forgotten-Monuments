using UnityEngine;
using System.Collections;

public class MoveCircularPath : MonoBehaviour {
	
	float angle = 0;
	float speed = (2*Mathf.PI)/5; //2*PI is 360 degrees, so you get 5 seconds to complete the circle
	float radius = 5;

	Vector3 spinningCubeStart;
	Vector3 bigCubeCenter;
//	
	// Use this for initialization
	void Start () {

		bigCubeCenter = new Vector3(2, 0, 6);


	
	}
	
	// Update is called once per frame
	void Update () {

		float x = 0;
		float y = 0;
		
		Vector3 direction = Vector3.zero;
		
		x = radius * Mathf.Cos(angle);
		y = radius * Mathf.Sin(angle);
		

		angle += 15 * Mathf.Deg2Rad * Time.deltaTime*5;

		transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 20 * Time.deltaTime);


	}
}

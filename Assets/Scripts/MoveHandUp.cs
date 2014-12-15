using UnityEngine;
using System.Collections;

public class MoveHandUp : MonoBehaviour {
	
	public Transform hand;
	public Vector3 destination;

	int counter;

	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other){
		//hand.transform.Translate(Vector3.up * Time.deltaTime, Space.Self);
		hand.transform.position = Vector3.Lerp (hand.transform.position, destination, Time.deltaTime*50);

	}
}

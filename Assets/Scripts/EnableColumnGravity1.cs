using UnityEngine;
using System.Collections;

public class EnableColumnGravity1 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {


		other.attachedRigidbody.useGravity = true;
}


}
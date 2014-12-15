using UnityEngine;
using System.Collections;

public class ActivateHand1 : MonoBehaviour {

	Vector3 column1Position;
	public GameObject hand1;
	public GameObject player;

	// Use this for initialization
	void Start () {
		column1Position = hand1.transform.position; //remembers the original position
		hand1.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
	//	Destroy (hand1.gameObject);
		//column1Position = column1Position + new Vector3 (0, 100, 0);
		if (other.collider.tag == player.tag) {
						Debug.Log ("in trigger");
			hand1.SetActive (true);
		}
	}
}

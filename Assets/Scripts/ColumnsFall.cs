using UnityEngine;
using System.Collections;

public class ColumnsFall : MonoBehaviour {

	Vector3 column1Position, column2Position;
	public GameObject column1, column2, column3, column4, column5;
	public GameObject shelf;
	public Vector3 destination;

	bool playerInTrigger;

	// Use this for initialization
	void Start () {
	
		column1Position = column1.transform.position; //remembers the original position
		column2Position = column2.transform.position;

		playerInTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}



}

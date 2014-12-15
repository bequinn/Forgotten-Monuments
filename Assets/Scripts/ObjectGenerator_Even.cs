using UnityEngine;
using System.Collections;

public class ObjectGenerator_Even : MonoBehaviour {
	
	public Transform spinningSculpture, pyramid, headGroup;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (monumentGenerator ());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("r")) {
			Application.LoadLevel (0);
		}
	}
	
	IEnumerator monumentGenerator(){
		
		int counter = 0;

		int charSoFar = 0;
		int positionX = -26;
		int positionZ = -91;

		int numPyramids = 0;
		int pyramidX = -6;
		int pyramidZ = -91;

		int numSpinningHeads = 0;
		int spinHeadX = - 45;
		int spinHeadY = - 80;

		int minX = -30;
		int maxX = 70;
		
		int minZ = -91;
		int maxZ = 5;

		float randomNumber;
		
		while (counter < 20) {
			
			randomNumber = Random.Range (0, 7f);
			
			if(randomNumber < 2f){
				//spinning head
				Instantiate(spinningSculpture, new Vector3 (spinHeadX, 0, spinHeadY), Quaternion.Euler(0, Random.Range (0, 360), 0));
				spinHeadX += 40;
				spinHeadY += 20;
			}
			
			if(randomNumber < 3f && randomNumber >= 2f){
				//pyramid

				if(numPyramids < 3){
				Instantiate(pyramid, new Vector3 (Random.Range (-6, 87), 13, pyramidZ), Quaternion.identity);
				pyramidX += 35;
				pyramidZ += 35;
				numPyramids ++;
				}
			}
			
			if(randomNumber < 6f && randomNumber > 4f){
				//head group
				Instantiate(headGroup, new Vector3 (positionX + 20, 0, positionZ + 20), Quaternion.Euler (0, Random.Range(0, 360), Random.Range (0, 360)));
				positionX += 1;
				positionZ += 4;
			}
			
			
			if (positionX >= 3) {
				charSoFar = 1; //reset the counter
				positionX = -26;
				spinHeadX = -45;
				//positionZ += 2;
			}
			
			counter++;
			yield return new WaitForSeconds(0.5f); //tells unity to take a break
			
		}
	}
}

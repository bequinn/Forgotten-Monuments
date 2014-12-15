using UnityEngine;
using System.Collections;

public class ObjectGenerator : MonoBehaviour {

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

		int charSoFar = 0;
		int positionX = 0;
		int positionZ = 0;
		int counter = 0;

		int minX = -30;
		int maxX = 70;

		int minZ = -100;
		int maxZ = 5;


		
		float randomNumber;

		while (counter < 12) {
			
			randomNumber = Random.Range (0, 7f);
			
			if(randomNumber < 2f){
				//spinning head
				Instantiate(spinningSculpture, new Vector3 (positionX + Random.Range(minX, maxX), 0, positionZ + Random.Range (minZ, maxZ)), Quaternion.Euler(0, Random.Range (0, 360), 0));
				positionX += 1;
				positionZ += 4;
			}
			
			if(randomNumber < 3f && randomNumber >= 2f){
				//pyramic
				Instantiate(pyramid, new Vector3 (positionX + Random.Range (minX+30, maxX), 13, positionZ + Random.Range (minZ, maxZ)), Quaternion.identity);
				positionX += 1;
				positionZ += 4;
			}
			
			if(randomNumber < 6f && randomNumber > 4f){
				//head cluster
				Instantiate(headGroup, new Vector3 (positionX + Random.Range (minX, maxX), 0, positionZ + Random.Range (minZ, maxZ)), Quaternion.Euler (0, Random.Range(0, 360), Random.Range (0, 360)));
				positionX += 1;
				positionZ += 4;
			}
			
	
			if (positionX >= 3) {
				charSoFar = 1; //reset the counter
				positionX = 0;
				//positionZ += 2;
			}
			
			counter++;
			yield return new WaitForSeconds(0.5f); //tells unity to take a break
			
		}
	}
}

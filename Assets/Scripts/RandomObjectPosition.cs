using UnityEngine;
using System.Collections;

public class RandomObjectPosition : MonoBehaviour {

	public Transform object1, object2, object3, object4, object5;

	public Transform camera, camera1;

	void Awake(){
		DontDestroyOnLoad(transform.camera);
		}

	// Use this for initialization
	void Start () {
		StartCoroutine (buildUpSculpture ()	);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("r")) {
			Application.LoadLevel(0);
		}
	}

	IEnumerator buildUpSculpture() {

		Vector3 position1 = new Vector3 (0, 0, 0);
		Vector3 position2 = new Vector3 (1, 0, 0);
		Vector3 position3 = new Vector3 (2, 0, 0);
		Vector3 position4 = new Vector3 (3, 0, 0);
		Vector3 position5 = new Vector3 (4, 0, 0);

		int charSoFar = 0;
		int positionX = 0;
		int positionZ = 0;
		int counter = 0;
		
		float randomNumber;
		
		
		while (counter < 1) {
			
			randomNumber = Random.Range (0, 5f);
			
			if(randomNumber < 1f){ //0
				//empire state
				Instantiate(object1, position1, Quaternion.identity);
				Instantiate(object2, position2, Quaternion.identity);
				Instantiate(object3, position3, Quaternion.identity);
				Instantiate(object4, position4, Quaternion.identity);
				Instantiate(object5, position5, Quaternion.identity);
			}
			
			if(randomNumber < 2f && randomNumber >= 1f){ //1
				Instantiate(object1, position1, Quaternion.identity);
				Instantiate(object3, position2, Quaternion.identity);
				Instantiate(object2, position3, Quaternion.identity);	
				Instantiate(object5, position4, Quaternion.identity);
				Instantiate(object4, position5, Quaternion.identity);
			}	
			if(randomNumber < 3f && randomNumber >= 2f){ //2
				Instantiate(object2, position1, Quaternion.identity);
				Instantiate(object1, position2, Quaternion.identity);
				Instantiate(object3, position3, Quaternion.identity);	
				Instantiate(object5, position4, Quaternion.identity);
				Instantiate(object4, position5, Quaternion.identity);
			}
			if(randomNumber < 4f && randomNumber >= 3f){ //3
				Instantiate(object2, position1, Quaternion.identity);
				Instantiate(object3, position2, Quaternion.identity);
				Instantiate(object4, position3, Quaternion.identity);
				Instantiate(object5, position4, Quaternion.identity);
				Instantiate(object1, position5, Quaternion.identity);			
			}

			if(randomNumber < 5f && randomNumber >= 4f){ //4
				Instantiate(object4, position1, Quaternion.identity);
				Instantiate(object5, position2, Quaternion.identity);
				Instantiate(object3, position3, Quaternion.identity);
				Instantiate(object2, position4, Quaternion.identity);
				Instantiate(object1, position5, Quaternion.identity);			
			}

			if(randomNumber < 6f && randomNumber >= 5f){ //5
				Instantiate(object5, position1, Quaternion.identity);
				Instantiate(object4, position2, Quaternion.identity);
				Instantiate(object3, position3, Quaternion.identity);
				Instantiate(object1, position4, Quaternion.identity);
				Instantiate(object2, position5, Quaternion.identity);			
			}

			
			counter++;
			yield return new WaitForSeconds(0.5f); //tells unity to take a break
			
		}

		}
}

//if random number = 1

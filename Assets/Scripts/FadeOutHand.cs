using UnityEngine;
using System.Collections;

public class FadeOutHand : MonoBehaviour {

	GameObject hand;
	Color startColor;
	Color endColor;
	Color currentColor;
	bool shouldFade = false;
	float startTime;
	float endTime;
	public float seconds = 5.0f;
	float t;   

	// Use this for initialization
	void Start () {
		startColor = gameObject.renderer.material.color;       
		endColor = new Color(startColor.r, startColor.g, startColor.b, 0.0f);  

		for ( int childIndex = 0; childIndex < gameObject.transform.GetChildCount(); childIndex++)
		{
			Transform child = gameObject.transform.GetChild(childIndex);           
			
			child.gameObject.AddComponent<FadeOutHand>();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			shouldFade = true;
			
			startTime = Time.time;
			
			endTime = startTime + seconds;
		}      
		
		Fade();
	}
	void Fade()
	{
		if ( shouldFade )
		{
			t = Time.time / endTime;
			
			currentColor = Color.Lerp(startColor, endColor, t);        
			
			gameObject.renderer.material.SetColor("_Color", currentColor);         
			
			if ( currentColor == endColor )
			{
				shouldFade = false;
				startTime = 0.0f;
				endTime = 0.0f;
				t= 0.0f;
			}
		}
	}
}

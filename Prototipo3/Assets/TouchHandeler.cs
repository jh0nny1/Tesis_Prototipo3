using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchHandeler : MonoBehaviour {

	public static GameObject photoDrag;
	Vector3 startPosition;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
			
			Touch touch = Input.GetTouch(0);

			if (touch.phase == TouchPhase.Began) {
			
				photoDrag = gameObject;
				startPosition = touch.position;
			}

			else if (touch.phase == TouchPhase.Moved) {
			
				transform.position = new Vector3 (touch.position.x, touch.position.y, transform.position.z);
			}

			else if (touch.phase == TouchPhase.Ended) {
			
				photoDrag = null;
				transform.position = startPosition;
			}
			
		
		}


		
	}
}

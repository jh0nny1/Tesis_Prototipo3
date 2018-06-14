using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveImage : MonoBehaviour {

	//public static bool guiTouch = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
		
			Touch touch = Input.GetTouch (0);


			if (touch.phase == TouchPhase.Began) {

				//startPos = touch.position;
			
				Vector3 pos;

				pos = new Vector3 (Camera.main.ScreenToWorldPoint (touch.position).x, Camera.main.ScreenToWorldPoint (touch.position).y, transform.position.z);
				transform.position = pos;
				//Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));

				//transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);
			
			}
		}
		
	}
}

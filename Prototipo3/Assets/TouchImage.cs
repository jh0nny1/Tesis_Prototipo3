using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchImage : MonoBehaviour {

	public static bool guiTouch = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//text.text = Input.touchCount.ToString();

		//for (var i = 0; i < Input.touchCount; i++) {

		//	if (Input.GetTouch(i).phase == TouchPhase.Moved || Input.GetTouch(i).phase == TouchPhase.Stationary) {

				// assign new position to where finger was pressed
		//		transform.position = new Vector3 (Input.GetTouch(i).position.x, Input.GetTouch(i).position.y, transform.position.z);

		//	}

		//}

		if (Input.touchCount > 0) {

			Touch touch = Input.GetTouch (0);

			if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began) {

				Vector3 pos;

				pos = new Vector3 (touch.position.x, touch.position.y, transform.position.z);
				transform.position = pos;
				guiTouch = true;
					
			} else {
			
				guiTouch = false;
			}


		}


}

}

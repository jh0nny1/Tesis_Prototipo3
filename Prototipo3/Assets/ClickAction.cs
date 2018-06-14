using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickAction : MonoBehaviour, IPointerClickHandler {

	//GameObject zoom;
	public GameObject ImagePanel;
	public Image image;
	//private ZoomControl example;

	//void Awake(){
	//	zoom = GameObject.Find ("Canvas/Zoom");
	//}

	//void Start(){
	
	//	GameObject.Find ("Canvas/Zoom").SetActive (false);
	//}



	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{
		
		//transform.position = new Vector3 (transform.position.x + 400f, transform.position.y - 120f, transform.position.z);
		//transform.localScale = new Vector3 (5f, 5f, 0f);
			
		//if (Resources.FindObjectsOfTypeAll ("Canvas/Zoom")) {
		//	Debug.Log ("Hola");
		//}
		if (GameObject.Find ("Canvas/Zoom")) {
			Debug.Log ("existo panel");			
		}
		if (GameObject.Find ("Canvas/Panel_general")) {
			Debug.Log ("existo panel general");
		}
		ImagePanel = GameObject.Find ("Canvas/Panel");
		image.sprite = eventData.pointerDrag.GetComponent<Image> ().sprite;

		
		ImagePanel.SetActive (true);
	}
	#endregion


}

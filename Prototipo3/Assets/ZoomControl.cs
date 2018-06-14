using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomControl : MonoBehaviour {

	GameObject zoom;
	public Image image;

	void Awake(){
		zoom = GameObject.Find ("Canvas/Zoom");
	}

	// Use this for initialization
	void Start () {

		GameObject.Find ("Canvas/Zoom").SetActive (false);
		
	}
	

}

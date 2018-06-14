using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PopulatedGrid : MonoBehaviour {

	public GameObject prefab;

	public int numberToCreate;



	// Use this for initialization
	void Start () {

		Populate ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Populate(){
	
		GameObject newOjb;

		for (int i = 0; i < numberToCreate; i++) {
		
			newOjb = (GameObject)Instantiate (prefab, transform);
			//newOjb.GetComponentInChildren<Image> ().color = Random.ColorHSV ();
			//newOjb.GetComponent<Image>().color = Random.ColorHSV();
		}
	}
}

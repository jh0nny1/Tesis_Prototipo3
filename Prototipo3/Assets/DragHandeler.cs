using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

	public Transform startParent;
	public bool exist_group1 = false;
	public bool exist_group2 = false;
	public bool exist_group3 = false;
	public bool exist_group4 = false;
	public enum Slot1{SLOT, NONSLOT};
	private Dictionary<int,GameObject> m_dragPhotos = new Dictionary<int,GameObject> ();
	GameObject placeHolder = null;


	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		placeHolder = new GameObject(this.name);
		var image = placeHolder.AddComponent<Image> ();
		var le = placeHolder.AddComponent<LayoutElement>();
		le.preferredWidth = this.GetComponent<LayoutElement> ().preferredWidth;
		le.preferredHeight = this.GetComponent<LayoutElement> ().preferredHeight;
		CanvasGroup canvas_group = placeHolder.AddComponent<CanvasGroup> ();
		placeHolder.transform.SetParent (this.transform.parent);
		placeHolder.AddComponent<DragHandeler> ();
		placeHolder.transform.localScale = transform.localScale;
		placeHolder.transform.SetSiblingIndex (this.transform.GetSiblingIndex ());
		image.sprite = this.GetComponent<Image> ().sprite;
		startParent = transform.parent;
		this.transform.SetParent (this.transform.parent.parent);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;


		if (GameObject.Find ("Canvas/Panel_general/group_selector1/" + gameObject.name) == null) {
			Debug.Log ("aun no existo en group 1");
			gameObject.GetComponent<DragHandeler> ().exist_group1 = true;
		}
		if (GameObject.Find ("Canvas/Panel_general/group_selector2/" + gameObject.name) == null) {
			Debug.Log ("aun no existo en group 2");
			gameObject.GetComponent<DragHandeler> ().exist_group2 = true;
		}
		if (GameObject.Find ("Canvas/Panel_general/group_selector3/" + gameObject.name) == null) {
			Debug.Log ("aun no existo en group 2");
			gameObject.GetComponent<DragHandeler> ().exist_group3 = true;
		}
		if (GameObject.Find ("Canvas/Panel_general/group_selector4/" + gameObject.name) == null) {
			Debug.Log ("aun no existo en group 2");
			gameObject.GetComponent<DragHandeler> ().exist_group4 = true;
		}


	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		
		//transform.position = Input.mousePosition;
		transform.position = eventData.position;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{

		transform.SetParent (startParent);

		if (gameObject.GetComponent<DragHandeler>().exist_group1 == false && GameObject.Find ("Canvas/Panel_general/group_selector1").activeInHierarchy) {
			Destroy (gameObject);
		}
		if (gameObject.GetComponent<DragHandeler>().exist_group2 == false && GameObject.Find ("Canvas/Panel_general/group_selector2").activeInHierarchy) {
			Destroy (gameObject);
		}
		if (gameObject.GetComponent<DragHandeler>().exist_group3 == false && GameObject.Find ("Canvas/Panel_general/group_selector3").activeInHierarchy) {
			Destroy (gameObject);
		}
		if (gameObject.GetComponent<DragHandeler>().exist_group4 == false && GameObject.Find ("Canvas/Panel_general/group_selector4").activeInHierarchy) {
			Destroy (gameObject);
		}


		if (gameObject.GetComponent<DragHandeler> ().exist_group1 == true || gameObject.GetComponent<DragHandeler> ().exist_group2 == true || gameObject.GetComponent<DragHandeler> ().exist_group3 == true || gameObject.GetComponent<DragHandeler> ().exist_group4 == true) {
			Destroy (gameObject.GetComponent<DragHandeler> ());
		}

		if (startParent.name == "Image_Selector1" || startParent.name == "Image_Selector2" || startParent.name == "Image_Selector3" || startParent.name == "Image_Selector4") {
			Destroy (gameObject);
		}
		GetComponent<CanvasGroup> ().blocksRaycasts = true;


	}

	#endregion
}

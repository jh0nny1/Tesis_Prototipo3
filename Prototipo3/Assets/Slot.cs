using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {
	

	public DragHandeler.Slot1 type = DragHandeler.Slot1.SLOT;

	
	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
	//	if (!item) {
	//		DragHandeler.photoBeingDragged.transform.SetParent (transform);
	//	}

		DragHandeler d = eventData.pointerDrag.GetComponent<DragHandeler>();
		Debug.Log (eventData.pointerDrag.name + "was dropped" + gameObject.name);
		if (d != null) {
			if (type == DragHandeler.Slot1.SLOT) {
				d.startParent = this.transform;

			}

		}
	}

	#endregion



}

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MouseDrag : MonoBehaviour, IDragHandler {

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		Debug.Log ("OnBeginDrag");
		this.transform.position = eventData.position;
	}

	#endregion
}
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(MeshCollider))]
public class MouseDrag : MonoBehaviour {


	public Camera cameraToLookAt;
	private Vector3 screenPoint;
	private Vector3 offset;

	void OnMouseDown(){
		screenPoint = cameraToLookAt.WorldToScreenPoint(gameObject.transform.position);

		offset = gameObject.transform.position - cameraToLookAt.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

	}

	void OnMouseDrag(){
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

		Vector3 curPosition = cameraToLookAt.ScreenToWorldPoint(curScreenPoint)+offset;
		transform.position = curPosition;
	}
}
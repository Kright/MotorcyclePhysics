using UnityEngine;
using System.Collections;

public class CamMovement : MonoBehaviour {

	public Transform target;

	public float r;
	private float phi;
	private float omega;

	public Vector2 mouseSensivity = new Vector2(100, 100);

	private Vector2 previousMousePos;
	private Transform thisTransform;

	// Use this for initialization
	void Start () {
		thisTransform = GetComponent<Transform>();
		phi = 180 / Mathf.PI * Mathf.Atan2(thisTransform.forward.x, thisTransform.forward.z);
		omega = -Mathf.Acos(thisTransform.forward.y)/Mathf.PI * 180f + 90f;

		previousMousePos = getMousePos();
	}

	// Update is called once per frame
	void LateUpdate () {
		var pos = getMousePos();
		var delta = pos - previousMousePos;

		phi += mouseSensivity.x * delta.x;
		omega += mouseSensivity.y * delta.y;
		omega = Mathf.Clamp(omega, -60, 60);

		var orientation = Quaternion.Euler(-omega, phi, 0);

		thisTransform.position = target.position + orientation * new Vector3(0, 0, -r);
		thisTransform.rotation = orientation;
	}

	private Vector2 getMousePos() {
		return new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
	}
}

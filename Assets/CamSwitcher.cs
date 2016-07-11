using UnityEngine;
using System.Collections;

public class CamSwitcher : MonoBehaviour {

	public Camera[] cameras;
	public int currentCam = 0;

	// Use this for initialization
	void Start () {
		foreach(Camera c in cameras) {
			c.enabled = false;
		}
		cameras[currentCam].enabled = true;

		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Confined;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C)) {
			cameras[currentCam].enabled = false;
			currentCam = (currentCam + 1) % cameras.Length;
			cameras[currentCam].enabled = true; 
		}

		if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
	}
}

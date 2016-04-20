using UnityEngine;
using System.Collections;

public class ViewRotator : MonoBehaviour {

    const float MOUSE_SENSITIVITY = 5.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X") * MOUSE_SENSITIVITY;
        float mouseY = Input.GetAxis("Mouse Y") * MOUSE_SENSITIVITY;
        Transform camera = transform.Find("Camera");
        // Another way: Camera camera = GetComponentInChildren<Camera>();
        camera.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.localRotation;
        transform.rotation = Quaternion.Euler(0, mouseX, 0) * transform.rotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cameraZoomIntro : MonoBehaviour {

    public Camera cam;
    public float zoomSpeed = 1f;
    public float fieldOfViewTarget = 60f;

	void Update () {
        if (cam.fieldOfView >= fieldOfViewTarget + zoomSpeed)
        {
            cam.fieldOfView -= zoomSpeed;
        } else
        {
            cam.fieldOfView = fieldOfViewTarget;
        }
	}
}

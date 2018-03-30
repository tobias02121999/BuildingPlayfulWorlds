using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_thirdPersonCamera : MonoBehaviour {

    private float rotationX = 0f;
    private float rotationY = 0f;

    public float sensitivityX = 1f;
    public float sensitivityY = 1f;

	void Update () {
        if (Input.GetMouseButton(1))
        {
            rotationX -= Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = GetComponentInParent<scr_playerMovement>().transform.eulerAngles.y;
        } else
        {
            rotationX -= Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY += Input.GetAxis("Mouse X") * sensitivityX;
        }

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
	}
}

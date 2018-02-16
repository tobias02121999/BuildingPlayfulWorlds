using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cameraControl : MonoBehaviour {

    public Vector3 positionCamera0;
    public Vector3 positionCamera1;
    public Vector3 positionCamera2;
    public float movementSpeed = 1f;
    public Camera switchCamera;

    private Vector3 targetPositionVector;
    private Vector3 targetRotationVector;
    private int activeCamera = 0;

    private void Update()
    {
        Vector3 playerPosition = this.transform.parent.parent.transform.position;

        if (Input.GetKey("1"))
        {
            activeCamera = 0;
        }

        if (Input.GetKey("2"))
        {
            activeCamera = 1;
        }

        if (Input.GetMouseButton(1))
        {
            activeCamera = 2;
        } else
        {
            if (activeCamera == 2)
            {
                activeCamera = 0;
            }
        }

        switch (activeCamera)
        {
            case 0:
                targetPositionVector = playerPosition + (transform.forward * positionCamera0.x) + (transform.up * positionCamera0.y) + (transform.right * positionCamera0.z);
                break;

            case 1:
                targetPositionVector = playerPosition + (transform.forward * positionCamera1.x) + (transform.up * positionCamera1.y) + (transform.right * positionCamera0.z);
                break;

            case 2:
                targetPositionVector = playerPosition + (transform.forward * positionCamera2.x) + (transform.up * positionCamera2.y) + (transform.right * positionCamera2.z);
                break;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPositionVector, movementSpeed * Vector3.Distance(transform.position, targetPositionVector));

        if (Input.GetKey(KeyCode.LeftAlt))
        {
            switchCamera.enabled = true;
            this.GetComponent<Camera>().enabled = false;
        }
    }
}

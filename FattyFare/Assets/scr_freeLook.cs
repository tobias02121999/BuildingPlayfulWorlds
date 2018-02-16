using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_freeLook : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public Camera switchCamera;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    private void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.localRotation = Quaternion.Euler(pitch, yaw, 0f);

        if (!Input.GetKey(KeyCode.LeftAlt))
        {
            yaw = 0f;
            pitch = 0f;
            switchCamera.enabled = true;
            this.GetComponent<Camera>().enabled = false;
        }
    }
}

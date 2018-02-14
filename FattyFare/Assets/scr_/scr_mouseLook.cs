﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_mouseLook : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public float speedR = 2.0f;
    public float playerHealth = 1.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float roll = 0.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (playerHealth > 0)
        {
            yaw = speedH * Input.GetAxis("Mouse X");
            pitch = -(speedV * Input.GetAxis("Mouse Y"));

            if (Input.GetKey("e"))
            {
                roll = -speedR;
            }

            if (Input.GetKey("q"))
            {
                roll = speedR;
            }

            if (!Input.GetKey("q") && !Input.GetKey("e"))
            {
                roll = 0.0f;
            }
        } else
        {
            yaw += Random.Range(-5f, 5f);
            pitch += Random.Range(-5f, 5f);
            roll += Random.Range(-5f, 5f);
        }

        transform.Rotate(pitch, yaw, roll);
    }
}

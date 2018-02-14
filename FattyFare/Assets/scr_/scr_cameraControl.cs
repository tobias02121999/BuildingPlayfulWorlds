using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cameraControl : MonoBehaviour {

    public Camera playerCamera1;
    public Camera playerCamera2;
    public Camera playerCamera3;
    public Camera playerCamera4;

    private int activeCamera = 1;

	private void Start () {
        playerCamera1.enabled = true;
        playerCamera2.enabled = false;
        playerCamera3.enabled = false;
        playerCamera4.enabled = false;
}

    private void Update()
    {
        if (Input.GetKey("1"))
        {
            activeCamera = 1;
        }

        if (Input.GetKey("2"))
        {
            activeCamera = 2;
        }

        if (Input.GetKey("3"))
        {
            activeCamera = 3;
        }

        if (Input.GetKey("4"))
        {
            activeCamera = 4;
        }

        if (activeCamera == 1)
        {
            playerCamera1.enabled = true;
        } else
        {
            playerCamera1.enabled = false;
        }

        if (activeCamera == 2)
        {
            playerCamera2.enabled = true;
        } else
        {
            playerCamera2.enabled = false;
        }

        if (activeCamera == 3)
        {
            playerCamera3.enabled = true;
        }
        else
        {
            playerCamera3.enabled = false;
        }

        if (activeCamera == 4)
        {
            playerCamera4.enabled = true;
        }
        else
        {
            playerCamera4.enabled = false;
        }
    }
}

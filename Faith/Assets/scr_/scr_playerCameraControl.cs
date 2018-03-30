using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerCameraControl : MonoBehaviour {

    public int currentCamera = 0;
    public Camera[] cam;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update () {
		if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (currentCamera < cam.Length - 1)
            {
                currentCamera += 1;
            } else
            {
                currentCamera = 0;
            }
        }

        for (int i = 0; i < cam.Length; i++)
        {
            if (i == currentCamera)
            {
                cam[i].enabled = true;
            } else
            {
                cam[i].enabled = false;
            }
        }
	}
}

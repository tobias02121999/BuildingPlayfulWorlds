using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_faceCamera : MonoBehaviour {

    private Transform target;
    private int currentCamera;

    void Update()
    {
        GameObject larvaPlayer = GameObject.Find("pre_playerLarva");

        currentCamera = larvaPlayer.GetComponent<scr_playerCameraControl>().currentCamera;
        target = larvaPlayer.GetComponent<scr_playerCameraControl>().cam[currentCamera].GetComponentInParent<Transform>();

        transform.LookAt(target);
    }
}

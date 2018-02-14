using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerShoot : MonoBehaviour {

    public int alarmDuration = 500;
    public GameObject rocket;
    public float rocketDistance = 1.0f;
    public int alarm = 0;

    private bool isShooting = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isShooting = true;
        } else
        {
            isShooting = false;
        }
    }

    private void FixedUpdate()
    {
        if (isShooting && alarm <= 0)
        {
            Instantiate(rocket, transform.position - (transform.up * rocketDistance), transform.rotation);
            alarm = alarmDuration;
        }

        if (alarm >= 1)
        {
            alarm--;
        }
    }
}

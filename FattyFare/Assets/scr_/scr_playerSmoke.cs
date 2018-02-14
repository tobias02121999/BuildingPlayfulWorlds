using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerSmoke : MonoBehaviour {

    public float alarmDuration = 100;
    public GameObject smoke;
    public float smokeDistanceForward = 0.0f;
    public float smokeDistanceRight = 0.0f;

    private float alarm = 0.0f;

    private void Update()
    {
        if (alarm <= 0)
        {
            Instantiate(smoke, transform.position + (transform.forward * (smokeDistanceForward + Random.Range(-0.1f, 0.1f))) + (transform.right * (smokeDistanceRight + Random.Range(-0.1f, 0.1f))), transform.rotation);
            Instantiate(smoke, transform.position + (transform.forward * (smokeDistanceForward + Random.Range(-0.1f, 0.1f))) - (transform.right * (smokeDistanceRight + Random.Range(-0.1f, 0.1f))), transform.rotation);
            alarm = alarmDuration;
        }

        alarm--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_reloadBar : MonoBehaviour {

    public float sizeX = 0.0f;
    public float sizeXMax = 1.0f;
    public float sizeY = 0.25f;
    public float sizeZ = 0.25f;

    private float alarm = 0.0f;
    private float alarmDuration = 0.0f;

    private void Update()
    {
        alarm = this.transform.parent.GetComponent<scr_playerShoot>().alarm;
        alarmDuration = this.transform.parent.GetComponent<scr_playerShoot>().alarmDuration;

        sizeX = (alarm / alarmDuration) * sizeXMax;

        if (alarm > 0)
        {
            transform.localScale = new Vector3(sizeX, sizeY, sizeZ);
        } else
        {
            transform.localScale = new Vector3(0, 0, 0);
        }
    }
}

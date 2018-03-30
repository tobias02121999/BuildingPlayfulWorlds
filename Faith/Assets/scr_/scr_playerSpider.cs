using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerSpider : MonoBehaviour {

    private float alarm;
    private float movementSpeedOld;

    public GameObject web;
    public float alarmDuration;
    public float offset = .5f;
    public float webMovementSpeedAmplifier = 1.5f;
    public float webSpawnDistance = 1.1f;

    void Start()
    {
        movementSpeedOld = GetComponentInParent<scr_playerMovement>().movementSpeed;
    }

    void Update () {
	    if (Input.GetMouseButton(0) && alarm <= 0)
        {
            Instantiate(web, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y, transform.position.z + Random.Range(-offset, offset)), transform.rotation);
            Instantiate(web, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y, transform.position.z + Random.Range(-offset, offset)), transform.rotation);
            Instantiate(web, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y, transform.position.z + Random.Range(-offset, offset)), transform.rotation);
            alarm = alarmDuration;
        }

        alarm--;
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Web")
        {
            if (other.GetComponent<scr_web>().activationTimer <= 0)
            {
                GetComponentInParent<scr_playerMovement>().movementSpeed = movementSpeedOld * webMovementSpeedAmplifier;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        GetComponentInParent<scr_playerMovement>().movementSpeed = movementSpeedOld;
    }
}

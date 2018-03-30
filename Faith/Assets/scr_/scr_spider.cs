using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_spider : MonoBehaviour {

    private float webSearchAlarm = 0f;
    private float webBuildAlarm = 0f;
    private float webPositionX;
    private float webPositionY;
    private float webPositionZ;
    private float webInstantiateAlarm;
    private float wanderMoveChanceOld;
    private float movementSpeedOld;

    public GameObject web;
    public float webInstantiateAlarmDuration;
    public float offset = .5f;
    public int state = 0;
    public float webSearchAlarmDurationMin = 0f;
    public float webSearchAlarmDurationMax = 0f;
    public float webBuildAlarmDuration = 0f;
    public float webAreaBuildRange = 5f;
    public float webAreaWanderRange = 10f;
    public float webMovementSpeedAmplifier = 1.5f;

    void Start()
    {
        webSearchAlarm = Random.Range(webSearchAlarmDurationMin, webSearchAlarmDurationMax);
        webBuildAlarm = webBuildAlarmDuration;
        wanderMoveChanceOld = GetComponentInParent<scr_enemyMain>().wanderMoveChance;
        movementSpeedOld = GetComponentInParent<scr_enemyMain>().movementSpeed;
    }

    void Update () {
	    switch (state)
        {
            //Find a suitable place to build a web
            case 0:
                GetComponentInParent<scr_enemyMain>().wanderMode = true;
                if (webSearchAlarm <= 0)
                {
                    webPositionX = transform.position.x;
                    webPositionY = transform.position.y;
                    webPositionZ = transform.position.z;
                    GetComponentInParent<scr_enemyMain>().wanderMoveChance = 1f;
                    GetComponentInParent<scr_enemyMain>().wanderAlarm = 0f;
                    state = 1;
                }

                webSearchAlarm--;
                break;

            //Build a web inside of a wander area
            case 1:
                GetComponentInParent<scr_enemyMain>().wanderModeArea = true;
                GetComponentInParent<scr_enemyMain>().wanderModeAreaRange = webAreaBuildRange;
                GetComponentInParent<scr_enemyMain>().webPositionX = webPositionX;
                GetComponentInParent<scr_enemyMain>().webPositionY = webPositionY;
                GetComponentInParent<scr_enemyMain>().webPositionZ = webPositionZ;

                if (webInstantiateAlarm <= 0)
                {
                    Instantiate(web, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y, transform.position.z + Random.Range(-offset, offset)), transform.rotation);
                    Instantiate(web, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y, transform.position.z + Random.Range(-offset, offset)), transform.rotation);
                    Instantiate(web, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y, transform.position.z + Random.Range(-offset, offset)), transform.rotation);
                    webInstantiateAlarm = webInstantiateAlarmDuration;
                }

                webInstantiateAlarm--;

                if (webBuildAlarm <= 0)
                {
                    state = 2;
                }

                webBuildAlarm--;
                break;

            //Wander around the web area
            case 2:
                GetComponentInParent<scr_enemyMain>().wanderModeAreaRange = webAreaWanderRange;
                GetComponentInParent<scr_enemyMain>().wanderMoveChance = wanderMoveChanceOld;
                break;
        }
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Web")
        {
            if (other.GetComponent<scr_web>().activationTimer <= 0)
            {
                GetComponentInParent<scr_enemyMain>().movementSpeed = movementSpeedOld * webMovementSpeedAmplifier;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        GetComponentInParent<scr_enemyMain>().movementSpeed = movementSpeedOld;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_enemyMain : MonoBehaviour {

    private float wanderAlarmArea = 0f;
    private float fecesAlarm = 0f;
    private float facingDirection = 0;
    private bool move = false;

    public float wanderAlarm = 0f;
    public float movementSpeed = 1f;
    public float fecesAlarmDurationMin = 1f;
    public float fecesAlarmDurationMax = 100f;
    public bool dropFeces = false;
    public GameObject fecesSmall;
    public bool wanderMode = false;
    public float wanderAlarmDurationMin = 1f;
    public float wanderAlarmDurationMax = 100f;
    public float wanderMoveChance = .5f;
    public bool wanderModeArea = false;
    public float wanderModeAreaRange = 0f;
    public float webPositionX;
    public float webPositionY;
    public float webPositionZ;

    void Start()
    {
        fecesAlarm = Random.Range(fecesAlarmDurationMin, fecesAlarmDurationMax);
    }

    void Update () {
        if (wanderMode)
        {
            if (wanderAlarm <= 0)
            {
                facingDirection = Random.Range(0f, 360f);
                if (Random.value <= wanderMoveChance)
                {
                    move = true;
                }
                else
                {
                    move = false;
                }
                wanderAlarm = Random.Range(wanderAlarmDurationMin, wanderAlarmDurationMax);
            }

            wanderAlarm--;

            transform.rotation = Quaternion.Euler(0, facingDirection, 0);

            if (wanderModeArea)
            {
                float dist = Vector3.Distance(transform.position, new Vector3(webPositionX, webPositionY, webPositionZ));

                if (dist >= wanderModeAreaRange && wanderAlarmArea <= 0)
                {
                    if (Random.value < .5)
                    {
                        facingDirection += Random.Range(90f, 180f);
                    } else
                    {
                        facingDirection += Random.Range(-90f, -180f);
                    }
                    wanderAlarmArea = 50;
                }

                wanderAlarmArea--;
            }
        } else
        {
            move = false;
        }

        if (fecesAlarm <= 0 && dropFeces)
        {
            Instantiate(fecesSmall, transform.position, transform.rotation);
            fecesAlarm = Random.Range(fecesAlarmDurationMin, fecesAlarmDurationMax);
        }

        fecesAlarm--;

        if (move)
        {
            transform.position += transform.forward * movementSpeed;
            GetComponentInChildren<scr_frameAnimator>().currentAnimation = 1;
        }
        else
        {
            GetComponentInChildren<scr_frameAnimator>().currentAnimation = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerStats : MonoBehaviour {

    public float fogStartCurrent;
    public float fogEndCurrent;
    public float fogStart = 5f;
    public float fogEnd = 10f;
    public float fogResetSpeed = .1f;
    public float eatingSpeed = .1f;
    public GameObject larvaPlayer;
    public GameObject cockroachPlayer;
    public GameObject spiderPlayer;
    public GameObject centipedePlayer;

    void Start()
    {
        fogStartCurrent = fogStart;
        fogEndCurrent = fogEnd;
    }

    void Update () {
        RenderSettings.fogStartDistance = fogStartCurrent;
        RenderSettings.fogEndDistance = fogEndCurrent;

        if (Input.GetKeyDown("i"))
        {
            GameObject larva = Instantiate(larvaPlayer, transform.position, transform.rotation);
            larva.name = "pre_playerLarva";
            DestroyObject(this.gameObject);
        }

        if (Input.GetKeyDown("o"))
        {
            GameObject cockroach = Instantiate(cockroachPlayer, transform.position, transform.rotation);
            cockroach.name = "pre_playerCockroach";
            DestroyObject(this.gameObject);
        }

        if (Input.GetKeyDown("p"))
        {
            GameObject spider = Instantiate(spiderPlayer, transform.position, transform.rotation);
            spider.name = "pre_playerSpider";
            DestroyObject(this.gameObject);
        }

        if (Input.GetKeyDown("u"))
        {
            GameObject centipede = Instantiate(centipedePlayer, transform.position, transform.rotation);
            centipede.name = "pre_playerCentipede";
            DestroyObject(this.GetComponentInParent<Transform>().gameObject);
        }

        //Reset the fog back to original
        if (fogStartCurrent <= fogStart - fogResetSpeed)
        {
            fogStartCurrent += fogResetSpeed;
        } else
        {
            if (fogStartCurrent >= fogStart + fogResetSpeed)
            {
                fogStartCurrent -= fogResetSpeed;
            } else
            {
                fogStartCurrent = fogStart;
            }
        }

        if (fogEndCurrent <= fogEnd - fogResetSpeed)
        {
            fogEndCurrent += fogResetSpeed;
        }
        else
        {
            if (fogEndCurrent >= fogEnd + fogResetSpeed)
            {
                fogEndCurrent -= fogResetSpeed;
            }
            else
            {
                fogEndCurrent = fogEnd;
            }
        }
    }
}

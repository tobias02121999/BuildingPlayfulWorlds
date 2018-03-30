using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_hole : MonoBehaviour {

    public GameObject buttonE;
    public GameObject waypoint;
    public GameObject larvaPlayer;
    public float interactRange = .5f;

    void OnTriggerStay (Collider collision)
    {
        if (collision.gameObject.tag == "Larva")
        {
            waypoint.SetActive(true);
            buttonE.SetActive(true);

            if (Input.GetKeyDown("e"))
            {
                if (!collision.GetComponent<scr_playerLarva>().underGround)
                {
                    collision.GetComponent<scr_playerLarva>().underGround = true;
                } else
                {
                    collision.GetComponent<scr_playerLarva>().underGround = false;
                }
            }
        } else
        {
            buttonE.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        buttonE.SetActive(false);
    }

    private void Update()
    {
        if (!GameObject.Find("pre_playerLarva"))
        {
            waypoint.SetActive(false);
        }
    }
}

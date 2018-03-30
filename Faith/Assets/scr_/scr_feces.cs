using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_feces : MonoBehaviour {

    public GameObject buttonE;
    public GameObject model;
    public float interactRange = .5f;
    public float amount = 1f;

    private float size = 1f;

	void OnTriggerStay (Collider collision) {
        if (collision.gameObject.tag == "Larva" && !collision.GetComponent<scr_playerLarva>().underGround)
        {
            buttonE.SetActive(true);
            if (Input.GetKey("e"))
            {
                size -= collision.GetComponent<scr_playerStats>().eatingSpeed / amount;
            }
        } else
        {
            buttonE.SetActive(false);
        }
	}

    void OnTriggerExit(Collider collision)
    {
        buttonE.SetActive(false);
    }

    void Update ()
    {
        model.transform.localScale = new Vector3(size, size, size);

        if (size < .1)
        {
            Destroy(this.gameObject);
        }
    }
}

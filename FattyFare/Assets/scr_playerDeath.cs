using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerDeath : MonoBehaviour {

    public GameObject explosion;
    public int timer = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (this.GetComponent<scr_playerStats>().playerHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (this.GetComponent<scr_playerStats>().playerHealth <= 0)
        {
            if (timer <= 0)
            {
                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }

            timer--;
        }
    }
}

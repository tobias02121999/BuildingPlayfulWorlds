using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerExplosion : MonoBehaviour {

    public GameObject explosion;
    public int explosionDensity = 10;

	void Start () {
        var x = explosionDensity;
	    while (x >= 1)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            x--;
        }
	}
}

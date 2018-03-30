using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_dirt : MonoBehaviour {

    public float alarm = 50f;
	
	//Run this code every single frame
	void Update () {
        if (alarm <= 0)
        {
            Destroy(this.gameObject);
        }

        alarm--;
	}
}

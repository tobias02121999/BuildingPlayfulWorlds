using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_smokeDestroy : MonoBehaviour {

    public int timer = 100;

    private void Update()
    {
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }

        timer--;
    }
}

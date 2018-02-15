using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerStats : MonoBehaviour {

    public int playerHealth = 1;

    private void Update()
    {
        if (Input.GetKey("k"))
        {
            playerHealth = 0;
        }
    }
}

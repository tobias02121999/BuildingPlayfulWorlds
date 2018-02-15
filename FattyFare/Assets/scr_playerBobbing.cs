using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerBobbing : MonoBehaviour {

    public float bobbingDistance = 2f;
    public float bobbingSpeed = .25f;

    private float yPos = 0;
    private bool moveUp = true;

    private void Update()
    {
        if (moveUp)
        {
            if (yPos <= bobbingDistance - bobbingSpeed)
            {
                yPos += bobbingSpeed;
            } else
            {
                yPos = bobbingDistance;
                moveUp = false;
            }
        } else
        {
            if (yPos >= -bobbingDistance + bobbingSpeed)
            {
                yPos -= bobbingSpeed;
            } else
            {
                yPos = -bobbingDistance;
                moveUp = true;
            }
        }

        transform.position += transform.up * yPos;
    }
}

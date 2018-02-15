using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_monitorScale : MonoBehaviour {

    public float sizeX = 0f;
    public float sizeZ = 0f;
    public float enlargePercentage = .1f;

    private bool activated = false;
    private float currentSizeX = 0f;
    private float currentSizeZ = 0f;

	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            activated = !activated;
        }

        if (activated)
        {
            if (currentSizeX <= sizeX - sizeX * (enlargePercentage / 100))
            {
                currentSizeX += sizeX * (enlargePercentage / 100);
            }
            else
            {
                currentSizeX = sizeX;
            }

            if (currentSizeZ <= sizeZ - sizeZ * (enlargePercentage / 100))
            {
                currentSizeZ += sizeZ * (enlargePercentage / 100);
            }
            else
            {
                currentSizeZ = sizeZ;
            }
        }
        else
        {
            if (currentSizeX >= sizeX * (enlargePercentage / 100))
            {
                currentSizeX -= sizeX * (enlargePercentage / 100);
            }
            else
            {
                currentSizeX = 0;
            }

            if (currentSizeZ >= sizeZ * (enlargePercentage / 100))
            {
                currentSizeZ -= sizeZ * (enlargePercentage / 100);
            }
            else
            {
                currentSizeZ = 0;
            }
        }

        transform.localScale = new Vector3(currentSizeX, 1f, currentSizeZ);
    }
}

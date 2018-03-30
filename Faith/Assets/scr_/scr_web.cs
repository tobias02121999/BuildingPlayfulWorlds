using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_web : MonoBehaviour {

    public float activationTimer = 25f;

	void Start () {
        transform.rotation = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
	}

    void Update()
    {
        activationTimer--;
    }
}

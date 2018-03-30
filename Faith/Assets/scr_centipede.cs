using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_centipede : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null)
        {
            Destroy(this.gameObject);
        }
	}
}

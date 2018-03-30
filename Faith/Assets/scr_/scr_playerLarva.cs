using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerLarva : MonoBehaviour {

    private int dirtInstantiateAlarm;

    public bool underGround;
    public GameObject model;
    public GameObject dirt;
    public int dirtInstantiateDuration = 5;
    public float offset = .5f;
	
	//Run this code every single frame
	void Update () {
	    if (underGround)
        {
            GetComponent<BoxCollider>().isTrigger = true;
            model.SetActive(false);

            if (dirtInstantiateAlarm <= 0)
            {
                Instantiate(dirt, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y, transform.position.z + Random.Range(-offset, offset)), transform.rotation);
                dirtInstantiateAlarm = dirtInstantiateDuration;
            }

            dirtInstantiateAlarm--;
        } else
        {
            GetComponent<BoxCollider>().isTrigger = false;
            model.SetActive(true);
        }
	}
}

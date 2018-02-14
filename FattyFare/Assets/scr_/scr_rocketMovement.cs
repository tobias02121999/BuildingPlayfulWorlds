using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rocketMovement : MonoBehaviour {

    public float speed = 1.0f;

    private void FixedUpdate()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}

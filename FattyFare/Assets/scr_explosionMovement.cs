using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_explosionMovement : MonoBehaviour {

    public float movementSpeed = 2f;

    private float xSpeed = 0f;
    private float ySpeed = 0f;
    private float zSpeed = 0f;

    private void Start()
    {
        xSpeed = Random.Range(-movementSpeed, movementSpeed);
        ySpeed = Random.Range(-movementSpeed, movementSpeed);
        zSpeed = Random.Range(-movementSpeed, movementSpeed);
    }

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * xSpeed;
        transform.position += transform.up * Time.deltaTime * ySpeed;
        transform.position += transform.right * Time.deltaTime * zSpeed;
    }
}

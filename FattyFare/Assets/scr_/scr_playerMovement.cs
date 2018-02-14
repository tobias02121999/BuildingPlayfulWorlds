using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerMovement : MonoBehaviour {

    private bool moveForward = false;
    private bool moveBackwards = false;
    private bool moveLeft = false;
    private bool moveRight = false;
    private bool moveUp = false;
    private bool moveDown = false;

    public float speed = 1f;

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (Input.GetKey("s"))
        {
            moveBackwards = true;
        }
        else
        {
            moveBackwards = false;
        }

        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }
        else
        {
            moveLeft = false;
        }

        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
        else
        {
            moveRight = false;
        }

        if (Input.GetAxis("Ascend") == 1)
        {
            moveUp = true;
        } else
        {
            moveUp = false;
        }

        if (Input.GetAxis("Descend") == 1)
        {
            moveDown = true;
        } else
        {
            moveDown = false;
        }
    }

    private void FixedUpdate()
    {
        if (moveForward)
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if (moveBackwards)
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }

        if (moveLeft)
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        if (moveRight)
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

        if (moveUp)
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }

        if (moveDown)
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }
    }
}

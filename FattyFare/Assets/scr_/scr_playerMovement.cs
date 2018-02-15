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
    private bool randomMoveForward;
    private bool randomMoveBackwards;
    private bool randomMoveLeft;
    private bool randomMoveRight;
    private bool randomMoveUp;
    private bool randomMoveDown;

    public float speed = 1f;

    private void Start()
    {
        randomMoveForward = Random.value > .5;
        randomMoveBackwards = Random.value > .5;
        randomMoveLeft = Random.value > .5;
        randomMoveRight = Random.value > .5;
        randomMoveUp = Random.value > .5;
        randomMoveDown = Random.value > .5;

        if (!(randomMoveForward && randomMoveBackwards && randomMoveLeft && randomMoveRight && randomMoveUp && randomMoveDown))
        {
            randomMoveDown = true;
        }
    }

private void Update()
    {
        if (this.GetComponent<scr_playerStats>().playerHealth > 0)
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
            }
            else
            {
                moveUp = false;
            }

            if (Input.GetAxis("Descend") == 1)
            {
                moveDown = true;
            }
            else
            {
                moveDown = false;
            }
        } else
        {
            moveForward = randomMoveForward;
            moveBackwards = randomMoveBackwards;
            moveLeft = randomMoveLeft;
            moveRight = randomMoveRight;
            moveUp = randomMoveUp;
            moveDown = randomMoveDown;
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

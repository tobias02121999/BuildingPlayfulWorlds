using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerMovement : MonoBehaviour {

    private float currentRotation = 0f;
    private float currentStrafeSpeed = 0f;
    private float currentMovementSpeed = 0f;

    public float strafeSpeed = .5f;
    public float movementSpeed = 1f;
    public float rotationSpeed = 5f;

	void Update () {
        currentMovementSpeed = Input.GetAxis("Vertical");

        if (GetComponent<scr_playerCameraControl>().currentCamera != 0)
        {
            currentStrafeSpeed = Input.GetAxis("Horizontal");
            currentRotation += Input.GetAxis("Mouse X") * rotationSpeed;

            if (currentMovementSpeed != 0 || currentStrafeSpeed != 0 || Input.GetAxis("Mouse X") != 0)
            {
                GetComponentInChildren<scr_frameAnimator>().currentAnimation = 1;
            }
            else
            {
                GetComponentInChildren<scr_frameAnimator>().currentAnimation = 0;
            }
        } else
        {
            currentStrafeSpeed = 0;

            if (Input.GetMouseButton(1))
            {
                currentStrafeSpeed = Input.GetAxis("Horizontal");
                currentRotation += Input.GetAxis("Mouse X") * rotationSpeed;

                if (currentMovementSpeed != 0 || Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Mouse X") != 0)
                {
                    GetComponentInChildren<scr_frameAnimator>().currentAnimation = 1;
                }
                else
                {
                    GetComponentInChildren<scr_frameAnimator>().currentAnimation = 0;
                }
            }
            else
            {
                currentRotation += Input.GetAxis("Horizontal") * rotationSpeed;

                if (currentMovementSpeed != 0 || Input.GetAxis("Horizontal") != 0)
                {
                    GetComponentInChildren<scr_frameAnimator>().currentAnimation = 1;
                }
                else
                {
                    GetComponentInChildren<scr_frameAnimator>().currentAnimation = 0;
                }
            }
        }
	}

    private void FixedUpdate()
    {
        transform.position += (transform.forward * currentMovementSpeed) * movementSpeed;
        transform.position += (transform.right * currentStrafeSpeed) * strafeSpeed;
        transform.rotation = Quaternion.Euler(0, currentRotation, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float jumpForce = 5f;
    private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    private bool isCrouching;
    private bool isSprinting;
    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        moveDirection = transform.TransformDirection(moveDirection);
        controller.Move(moveDirection * moveSpeed * Time.deltaTime); 

        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                isJumping = true;
            }
        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
            isJumping = false;
        }

        if(isJumping == true)
        {
            moveDirection.y = jumpForce;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }
}

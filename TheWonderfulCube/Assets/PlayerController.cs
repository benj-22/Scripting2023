using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    private bool isCrouching;
    private bool isSprinting;
    private bool isGrounded;

    private float originalControllerHeight = 2.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        isGrounded = true;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        moveDirection.x = horizontalInput * moveSpeed;
        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection.z = verticalInput * moveSpeed;

         if (Input.GetKeyDown(KeyCode.C))
        {
            isCrouching = !isCrouching;
            if (isCrouching)
            {
                controller.height = originalControllerHeight / 2f;
            }
            else
            {
                controller.height = originalControllerHeight;
            }
        }

        if(isGrounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }
       
        controller.Move(moveDirection * Time.deltaTime);
    }
}

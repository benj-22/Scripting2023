using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float jumpForce = 5f;
    public float gravity = 9.81f;
    public CharacterController controller;
    public Vector3 moveDirection;
    public bool isJumping = false;
    // Start is called before the first frame update
    public void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    public void Update()
    {
       float verticalInput = Input.GetAxis("Vertical");
       float horizontalInput = Input.GetAxis("Horizontal");

       Vector3 inputDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
       Vector3 moveDirection = Quaternion.Euler(0, transform.eulerAngles.y, 0) * inputDirection;
       transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

       if (controller.isGrounded)
       {    
            if(Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
                isJumping = true;
            }
       }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
            isJumping = false;
        }

       controller.Move(moveDirection * Time.deltaTime);
    }
}

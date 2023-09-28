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
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CharacterController>()>;
    }

    // Update is called once per frame
    void Update()
    {
       float verticalInput = Input.GetAxis("Vertical");
       float horizontalInput = Input.GetAxis("Horizontal");

       Vector3 inputDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
       Vector3 moveDirection = Quaternion.Euler(0, transform.eulerAngles.y, 0) * inputDirection;
       transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}

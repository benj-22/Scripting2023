using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float gravity = 9.81f;
    public CharacterController controller;
    public Vector3 moveDirection;
    public bool isJumping;
    // Start is called before the first frame update
    public void Start()
    {
        controller = GetComponent<CharacterController>();

        if (controller ==null)
        {
            Debug.LogError("No CharacterController component for this object!");
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (controller == null)
        {
            return;
        }

       float verticalInput = Input.GetAxis("Vertical");
       float horizontalInput = Input.GetAxis("Horizontal");

       Vector3 inputDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
       Vector3 moveDirection = Quaternion.Euler(0, transform.eulerAngles.y, 0) * inputDirection;
       transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}

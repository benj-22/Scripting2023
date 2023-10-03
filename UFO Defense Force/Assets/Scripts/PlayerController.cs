using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    public float xRange;

    void Start()
    {
        
    }

    void Update()
    {
        //variable initialized--set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves character left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);    

        //keeps player within bounds (left)
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            //Time.deltaTime means it moves by meters/s instead of meters/frame

        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            //the Vector is relative to the object and not the world-->object's forward instead of world's

        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            //when using an object w/ a collider, use physics stuff instead of rotate
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}

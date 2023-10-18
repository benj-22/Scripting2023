using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardLaser : MonoBehaviour
{
   public float laserSpeed = 10.0f;
   

    // Update is called once per frame
    void Update()
    {
        //move GameObject forward
        transform.Translate(Vector3.forward * Time.deltaTime * laserSpeed);
    }
}

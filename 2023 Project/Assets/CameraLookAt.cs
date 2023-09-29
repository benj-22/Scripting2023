using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour //make sure to apply script to camera
{
    public Transform target; //the object we wish to look for
    
    void Update ()
    {
        transform.LookAt(target); //tells object to look at target
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
   public float speed = 50.0f;
   private bool scriptEnabled;

   void Start()
   {
        enabled = true;
   }

    // Update is called once per frame
    void Update()
    {
        //move GameObject forward
        if(enabled)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

    }

    void OnTriggerEnter(Collider other) //once Trigger has been entered, record collision in the argument variable "other"
   {
        enabled = false;
   }
}

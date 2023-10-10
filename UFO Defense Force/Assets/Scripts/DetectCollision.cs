using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
        Destroy(other.gameObject); //destroy collided object
        Destroy(gameObject); //destroy this object
   }
}

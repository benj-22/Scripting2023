using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
   public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        //move GameObject down
        transform.Translate(Vector3.forward * -1 * Time.deltaTime * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }

    void Update()
        /* Called every frame
        FixedUpdate intervals are consistent--same time between calls
        Used for regular updates such as:
        Adjusting physics */

        //you can add functions quickly with ctr + shift + m for monoBehaviour wizard :O
    {
        Debug.Log("Update time: " + Time.deltaTime);
    }
}

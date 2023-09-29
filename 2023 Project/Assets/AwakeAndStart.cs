using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{

    void Awake() /*used before Start, even when it isn't enabled
                    so basically everything before Start is automatically part of Awake */
    {
        Debug.Log("Awake called.");
    }
    // Start is called before the first frame update as long as it's enabled
    void Start()
    {
        Debug.Log("Start called.")
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

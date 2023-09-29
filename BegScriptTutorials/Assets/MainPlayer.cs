using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public string myName = "none";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive, and my name is " + myName);
    }
}

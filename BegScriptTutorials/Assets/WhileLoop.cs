using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsInSink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while(cupsInSink > 0)
        {
            Debug.Log ("1 dish done!");
            cupsInSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

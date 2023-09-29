using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    private Light myLight
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<myLight>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(Keycode.Space))
        {
            myLight.enabled = !myLight.enabled; //"set this to whatever it's not at this moment"
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //double slashes for a single-line comment

        /* Slash and asterisk to have multiple lines!
         * see how epic this is?
         **/
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log ("I'm falling!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

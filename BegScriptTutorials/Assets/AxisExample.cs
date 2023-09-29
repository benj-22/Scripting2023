using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
/*Input.GetAxis works like GetButton and Key, but returns float
    instead of bool between -1 and 1
    set up in input manager */
public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;
    
    
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;
        
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
}
using UnityEngine;
using System.Collections;

public class InvokeScript : MonoBehaviour 
{
    public GameObject target;
    
    
    void Start()
    {
        Invoke ("SpawnObject", 2);
        //only methods with empty parenthesis and void can be invoked
    }
    
    void SpawnObject()
    {
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}
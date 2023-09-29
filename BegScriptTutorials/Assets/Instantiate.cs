using UnityEngine;
using System.Collections;
//used to create clones of game objects
public class Instantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    
    
    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            //drag and drop invisible barrellEnd object into the inspector in variable barrelEnd
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}
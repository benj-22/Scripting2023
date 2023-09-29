using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour
{

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); //if has rigidbody attached
        //like attaching collider
    }

    void OnMouseDown ()
    {
        rb.AddForce(-transform.forward * 500f); //500f is amount of force
        rb.useGravity = true; //adds gravity so it will fall
    }
}
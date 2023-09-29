using UnityEngine;
using System.Collections;

public class RocketDestruction : MonoBehaviour
{
    void Start()
    {
        Destroy (gameObject, 1.5f); //destroys after 1.5 seconds
    }
}
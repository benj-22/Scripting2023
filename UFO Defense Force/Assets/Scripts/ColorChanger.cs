using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ColorChanger : MonoBehaviour
{
    public bool startState = true;
    public float betweenBlinks = .1f;
 
    void Start()
    {
        StartCoroutine(blink());
    }
 
    IEnumerator blink()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = startState;
 
            while (startState)
            {
                GetComponent<Renderer> ().material.color = Color.red;
                yield return new WaitForSeconds(betweenBlinks);
                GetComponent<Renderer>().material.color = Color.blue;
                yield return new WaitForSeconds(betweenBlinks);
                GetComponent<Renderer>().material.color = Color.green;
                yield return new WaitForSeconds(betweenBlinks);
                GetComponent<Renderer>().material.color = Color.white;
                yield return new WaitForSeconds(betweenBlinks);

            }
    }
 
    // Update is called once per frame
    void Update()
    {
       
    }
}



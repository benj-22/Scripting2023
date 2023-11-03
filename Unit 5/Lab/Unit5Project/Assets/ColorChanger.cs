using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public float betweenBlinks = .1f;

    public void ChangeColor()
    {
        StartCoroutine(blink());
    }
    IEnumerator blink()
    {
        Renderer renderer = GetComponent<Renderer>();
 
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

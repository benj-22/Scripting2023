using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    //array to store UFO ships
    public GameObject[] ufoPreFabs; //of type GameObject, brackets show that it's an array
    public int ufoIndex; //picks from set of values in UFO prefabs
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
            Instantiate(ufoPreFabs[ufoIndex],new Vector3(0,0,20), ufoPreFabs[ufoIndex].transform.rotation);
    }
}

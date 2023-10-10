using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    //array to store UFO ships
    public GameObject[] ufoPreFabs; //of type GameObject, brackets show that it's an array
    private float spawnRangeX  = 20f;
    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUfo", startDelay, Random.Range(1,4));
    }
    
    // Update is called once per frame
    void Update()
    {
            
    }

    void SpawnRandomUfo()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        int ufoIndex = Random.Range(0,ufoPreFabs.Length); //picks from set of values in UFO prefabs, ufoPreFabs.Length makes it so we can extend array length if needed
        Instantiate(ufoPreFabs[ufoIndex],spawnPos, ufoPreFabs[ufoIndex].transform.rotation); // Spawns indexed ufo from the array at random position on x axis
    }
}

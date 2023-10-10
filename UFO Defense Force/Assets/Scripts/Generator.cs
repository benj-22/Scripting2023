using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject powerUp;
    public int numberOfPowerups;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerup", 2.0f, Random.Range(1,45));//);
    }

    void SpawnPowerup()
    {
        for(int i = 0; i < numberOfPowerups; i++)
        {
            Instantiate(powerUp, GeneratedPosition(), Quaternion.identity);
        }
    }

    Vector3 GeneratedPosition()
    {
        int x,y,z;
        x = UnityEngine.Random.Range (-19,20);
        y = UnityEngine.Random.Range (0,1);
        z = UnityEngine.Random.Range (17,20);
        return new Vector3(x,y,z);
    }
}

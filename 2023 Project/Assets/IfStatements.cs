using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float cubeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        cubeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if(cubeTemperature > hotLimitTemperature)
        {
            print("The cube is too hot now.");
        }
        
        else if(cubeTemperature < coldLimitTemperature)
        {
            print("Now the cube is too cold.");
        }

        else
        {
            print("Ahhhh that's the right temperature...");
        }
    }
}

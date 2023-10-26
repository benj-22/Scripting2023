using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    [SerializeField] private FloatData healthValue;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("HP obtained");

            //Apply the health value to the player
            ApplyHealth(other.gameObject);

            //Destroy the health powerup game object
            Destroy(gameObject);
        }
    }

    private void ApplyHealth(GameObject player)
    {
        //Retrieve the player's health component (e.g., HealthController script)
        HealthController healthController = player.GetComponent<HealthController>();

        //Check if the player has a health component
        if(healthController != null)
        {
            Debug.Log("health controller found");
            //Add the health value to the player's current health
            healthController.AddHealth(healthValue.Value);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player collected the pickup
            PlayerController playerController = other.GetComponent<PlayerController>();
            
            if (playerController != null)
            {
                playerController.AddToInventory(1); // Add the pickup's value to the player's inventory
            }

            // Destroy the pickup
            Destroy(gameObject);
        }
    }
}
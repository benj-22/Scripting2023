using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh Pro namespace added to access the Unity libraries for UI

public class PickupManager : MonoBehaviour
{
    public int pickupCount; //keeps count of pickups
    public TextMeshProUGUI pickupText; //visual text element to be modified for pickups

    public void IncreasePickup(int amount) //method increases score by predetermined amount set in score variable when called
    {
        pickupCount += amount;
        UpdatePickupText();
    }

    public void UpdatePickupText() //updates the score in HUD UI Text
    {
        pickupText.text = "Capsules: " + pickupCount;
    }
}

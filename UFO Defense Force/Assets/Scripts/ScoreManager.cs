using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh Pro namespace added to access the Unity libraries for UI

public class ScoreManager : MonoBehaviour
{
    public int score; //keeps score value
    public TextMeshProUGUI scoreText; // visual text element to be modified
    
    
    //IncreaseScore is a custom method
    public void IncreaseScore(int amount) //method increases score by predetermined amount set in score variable when called
    {
        score += amount;
        UpdateScoreText();
    }

    
    public void DecreaseScore(int amount) //method decreases score by predetermined amount set in score variable when called
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() //updates the score in HUD UI Text
    {
        scoreText.text = "Score: " + score;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   public ScoreManager scoreManager; //store reference to score manager
   public GameManager gameManager;

   public int scoreToGive;

   void Start()
   {
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //find ScoreManager gameobject and reference ScoreManager script component
      gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
   }

   void OnTriggerEnter(Collider other) //once Trigger has been entered, record collision in the argument variable "other"
   {
      gameManager.isGameOver = true;
      scoreManager.IncreaseScore(scoreToGive); //increase the score
      Destroy(gameObject); //destroy this object
      Destroy(other.gameObject); //destroy collided object
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -20.0f;
    public GameManager gameManager;
    void Awake()
    {
        Time.timeScale = 1;
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            gameManager.isGameOver = true;
            Debug.Log("Game Over...");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;
    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            Debug.Log("endgame method initialized");
            EndGame(); //starts endgame when isgameover is true
        }
        else
            gameOverText.gameObject.SetActive(false); //keep ui text game over hidden
            //Debug.Log("GameOverText found");
    }

    public void EndGame() //endgame method
    {
        Debug.Log("text displayed");
        gameOverText.gameObject.SetActive(true); //ui text is shown
        Time.timeScale = 0; //casts stop on the game
    }
}

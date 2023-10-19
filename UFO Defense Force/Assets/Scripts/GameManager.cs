using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;
    private GameObject gameOverText;
    public int sceneToLoad;

    void Awake()
    {
        //Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            //Debug.Log("endgame method initialized");
            EndGame(); //starts endgame when isgameover is true
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void EndGame() //endgame method
    {
        //Debug.Log("text displayed");
        //gameOverText.gameObject.SetActive(true); //ui text is shown
        SceneManager.LoadScene(sceneToLoad); //Which scene will load
        //Time.timeScale = 0; //casts stop on the game
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public AudioClip start;
    public AudioClip quit;
    private AudioSource menuAudio;

    void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }

    IEnumerator DelayedStart()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneToLoad); //Which scene will load
    }

    // Start is called before the first frame update
    public void StartGame()
    {
        menuAudio.PlayOneShot(start);
        StartCoroutine(DelayedStart());
    }

    public void QuitGame()
    {
        menuAudio.PlayOneShot(quit);
        Application.Quit();
        Debug.Log("Quit Game");
    }
}

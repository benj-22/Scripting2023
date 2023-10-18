using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    public float xRange;

    public GameObject ufo;
    public EnemySpawnManager spawnManager;

    public Transform blaster;
    public GameObject laser;
    public GameManager gameManager;
    public int pickups;
    public ParticleSystem blast;
    public ParticleSystem gameOver;
    public MeshRenderer player;
    public BoxCollider box;

    public AudioClip laserBlast;
    public AudioClip pickupGet;
    public AudioClip playerDeath;
    private AudioSource playerAudio;

    void Awake()
    {
        blast.Stop();
        gameOver.Stop();
    }

    void Start()
    {
        pickups = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
        spawnManager = ufo.GetComponent<EnemySpawnManager>();
    }

    void Update()
    {
        //variable initialized--set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves character left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);    

        //keeps player within bounds (left)
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        
        //Right side wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }

        //If spacebar is pressed, fire laser
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)//spacebar pressed and game is running, lasers are fired. Doesn't shoot when game is over
        {
            //Create laser at the blaster transform position, maintaining the transform rotation of laser
            Instantiate(laser, blaster.transform.position, laser.transform.rotation);
            blast.Play();
            playerAudio.PlayOneShot(laserBlast);
        }
        
    }

    IEnumerator DelayedDestroy()
    {
        yield return new WaitForSeconds(2);
        gameManager.isGameOver = true;
        Debug.Log("Game Over...");
        Destroy(gameObject);
        Time.timeScale = 0;
    }
    
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerupContainer"))
        {
            pickups++;
            // Check if the colliding object is the Player
            Destroy(other.gameObject); // Destroy the PowerupContainer
            Debug.Log("Powerups: " + pickups);
            playerAudio.PlayOneShot(pickupGet);
        }

        if (other.CompareTag("Ufo"))
        {
            gameOver.Play();
            playerAudio.PlayOneShot(playerDeath);
        }
    }
}

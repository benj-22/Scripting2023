using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager
    public ParticleSystem explosion;
    public int scoreToGive;
    public MeshRenderer ufo;
    public SphereCollider sphere;

    public AudioClip boom;
    private AudioSource ufoAudio;

    void Awake()
    {
        explosion.Stop();
    }

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        ufo.enabled = true;
        sphere.enabled = true;
        ufoAudio = GetComponent<AudioSource>();
    }

    IEnumerator DelayedDestroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Projectile"))
      {
        explosion.Play();
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(other.gameObject);
        ufo.enabled = false;
        sphere.enabled = false;
        StartCoroutine(DelayedDestroy());
        ufoAudio.PlayOneShot(boom);
      }
      else
      {
         explosion.Play();
        scoreManager.IncreaseScore(scoreToGive);
        ufo.enabled = false;
        sphere.enabled = false;
        StartCoroutine(DelayedDestroy());
        ufoAudio.PlayOneShot(boom);
      }
    }
}

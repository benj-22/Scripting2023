using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    //[SerializeField] 
    private float currentHealth;

    [SerializeField]
    private float respawnTime;

    [SerializeField]
    private Text healthText;

    private MeshRenderer meshRenderer;

    private bool isDead;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); // Fix the typo here
        //currentHealth = maxHealth;
        UpdateUI();
    }

    public void ApplyDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            meshRenderer.enabled = false;

            StartCoroutine(RespawnAfterTime());
        }

        UpdateUI();
    }

    private IEnumerator RespawnAfterTime()
    {
        yield return new WaitForSeconds(respawnTime); // Fix the typo here
        ResetHealth();
    }

    private void ResetHealth()
    {
        currentHealth = maxHealth;
        isDead = false;
        meshRenderer.enabled = true;
        UpdateUI();
    }

    private void UpdateUI()
    {
        healthText.text = "The health: " + currentHealth + "/" + maxHealth;
    }

    public void AddHealth(float heal)
    {
        Debug.Log("health added"); 
        currentHealth += heal;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            UpdateUI();
        }

        UpdateUI();
    }
}

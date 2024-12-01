using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int currentHealth = 0;
    [SerializeField] int maxHealth = 100;

    public PlayerController playerController;

    public Slider healthBar;

    public int healing = 20;
    private void Start()
    {
        currentHealth = maxHealth;

        healthBar.maxValue = maxHealth;
    }
    void FixedUpdate()
    {
        healthBar.value = currentHealth;
    }
    public void dmgUnit(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        if (currentHealth <= 0)
        {
            playerController.enabled = false;
            Destroy(gameObject);
        }
        healthBar.value = currentHealth;
    }

    public void healUnit(int healAmount)
    {
        if (currentHealth >= 0 && currentHealth <= 100)
        {
            currentHealth += healAmount;
        }
        healthBar.value = currentHealth;
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("healing"))
        {
            healUnit(healing);
            Destroy(other.gameObject);
        }
    }
}

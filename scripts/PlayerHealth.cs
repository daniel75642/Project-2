using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    public int MAX_HEALTH = 5;

    public int extraHealth;

    public SpriteRenderer playerSr;
    public PlayerContoller playerController;
    public AttackArea attackArea;


    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            playerSr.enabled = false;
            playerController.enabled = false;
            attackArea.enabled = false;
        }
    }
}

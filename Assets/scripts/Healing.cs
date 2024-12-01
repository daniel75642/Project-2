using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    public int heal = 1;

    public PlayerHealth playerHealth;

    private int damage = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (playerHealth.health < playerHealth.MAX_HEALTH)
            {
                playerHealth.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}

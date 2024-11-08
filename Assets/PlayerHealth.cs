using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;       // player health
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;  // start out with full health
    }

    // function to handle taking damage
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // die debug command and game over
    void Die()
    {
        Destroy(gameObject);

        Debug.Log("You died, will add an actual game over screen later");
        
    }
}

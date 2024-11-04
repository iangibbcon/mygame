using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
 public int health = 5;

   
    public void TakeDamage()
    {
        health--;

            if (health == 0)
            {
            EnemyDeath();
            }
    }

    public void EnemyDeath()
    {
         Destroy(gameObject);
    }


    // Update is called once per frame
}

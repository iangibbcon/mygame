using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollisionCenter : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // prevent the player from moving into the enemy's space
        if (collision.gameObject.name == "Square")
        {
            Debug.Log("the square works");
        }
    }
}
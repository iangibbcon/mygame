using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;       // use the same prefab the player has
    public Transform bulletSpawnPoint;    
    public float fireRate = 2f;           // rate of fire
    private float nextFireTime = 0f;      // need a timer
    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        // create the bullet at a spawn point
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // have it move left at 5 units/sec
        rb.velocity = Vector2.left * 5f; 

        // stop the spam
        Destroy(bullet, 5f);
    }
}

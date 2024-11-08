using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour

// all of this should only  be used for the enemy bullets
{

    public float speed = 5f; // same as the player
    public int damage = 1;  // 1 damage per shot
void Start()
    {
        // go left
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // damage script
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            // remove the bullet once you get hit
            Destroy(gameObject);
        }

        
    }
}






//get rid of this because it doesn't work

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float bulletSpeed = 10f;
    public Transform bulletSpawnPoint;

    void Update()
    {
        // fire when space is pressed, maybe change later.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        // Instantiate a new bullet at the spawn point
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // Get the Rigidbody2D of the bullet and set its velocity to move to the right
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * bulletSpeed;

        // Destroy the bullet after 5 seconds to avoid memory leaks
        Destroy(bullet, 5f);
    }
}
/*






/* none of this works
public class Bullet : MonoBehaviour
{
    public GameObject BulletPrefab;

    public float bulletSpeed = 5f;

    public Vector2 spawnPoint;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //press space to shoot
        {
            FireBullet();
        }
        
    }

void Firebullet()
{
    GameObject bullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);

    Rigidbody2d rb = bullet.Getcomponent<Rigidbody2D>();
    if (rb == null)
    {
        rb = bullet.AddComponent<Rigidbody2d>();
    }
// make it go to the right side of the screen
    rb.velocity = new Vector2(-bulletSpeed, 0);
    }
}

*/
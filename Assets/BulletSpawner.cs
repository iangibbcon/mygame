using System.Collections;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float bulletSpeed = 10f; // speed
    public Transform bulletSpawnPoint; // tto the right of the player)
    
    private ReloadSystem reloadSystem;

    void Start()
    {
        reloadSystem = new ReloadSystem(4, 3f); // Initialize with 4 bullets and 3-second reload time
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && reloadSystem.CanShoot())
        {
            FireBullet();
            reloadSystem.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R) && !reloadSystem.IsReloading)
        {
            StartCoroutine(reloadSystem.Reload());
        }
    }

    public int GetCurrentAmmo()
{
    return reloadSystem.CurrentAmmo; // expose current ammo to AmmoDisplay
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






/*using System.Collections;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float bulletSpeed = 10f;
    public Transform bulletSpawnPoint;
    private ReloadSystem reloadSystem;


 void Start()
    {
        reloadSystem = new ReloadSystem(4, 3f); // start out with full ammo
    }


    void Update()
    {
        // fire when space is pressed, maybe change this later.
        if (Input.GetKeyDown(KeyCode.Space) && reloadSystem.CanShoot())
        {
            FireBullet();
            reloadSystem.Shoot();
        }

         if (Input.GetKeyDown(KeyCode.R) && !reloadSystem.IsReloading) //reload with r and disable reloading if you're already doing it
        {
            StartCoroutine(reloadSystem.Reload());
        }
    }

    void FireBullet()
    {
        // spawn bullet here
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // set bullet speed
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * bulletSpeed;

        // clean up after 5 seconds
        Destroy(bullet, 5f);
    }
}









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
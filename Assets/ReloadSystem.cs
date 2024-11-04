using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadSystem
{
    private int maxBullets;      
    private int currentBullets;  
    public bool IsReloading { get; private set; }  
    private float reloadTime;    // set a custom reload time

    public ReloadSystem(int maxBullets, float reloadTime)
    {
        this.maxBullets = maxBullets;
        this.currentBullets = maxBullets; // Start with full ammo
        this.reloadTime = reloadTime;
        IsReloading = false;
    }
    public int CurrentAmmo
{
    get { return currentBullets; }
}

    
    public bool CanShoot()
    {
        return currentBullets > 0 && !IsReloading;
    }

    // lower the bullet count
    public void Shoot()
    {
        if (currentBullets > 0)
        {
            currentBullets--;  // shooting lowers clip size by 1
        }
    }

    // coroutine to handle reloading
    public IEnumerator Reload()
    {
        IsReloading = true;
        Debug.Log("reloading...");
        yield return new WaitForSeconds(reloadTime);  // reload time
        currentBullets = maxBullets;  // refill
        IsReloading = false;
        Debug.Log("reload complete");
    }
}
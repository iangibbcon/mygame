using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using TMPro; //use this instead

public class AmmoDisplay : MonoBehaviour
{
    public TextMeshProUGUI ammoText;           
    public BulletSpawner bulletSpawner;  // bring in this scripts

    void Start()
    {
        if (bulletSpawner == null)
        {
            Debug.LogError("BulletSpawner reference not set!"); //debug
            return;
        }

        UpdateAmmoText(); //update on start
    }

    void Update()
    {
        UpdateAmmoText();
    }

    void UpdateAmmoText()
    {
        // get ammo count and update
        int currentAmmo = bulletSpawner.GetCurrentAmmo();
        ammoText.text = "Current Ammo: " + currentAmmo;
    }
}
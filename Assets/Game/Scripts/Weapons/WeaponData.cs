using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Weapon", menuName = "FPS/Weapon")]
public class WeaponData : ScriptableObject
{
    [Header("Weapon Properties")]
    [Tooltip("Here we have the name, amounts and prefabs")]
    public string weaponName = "Weapon Name";
    public int weaponIndex = -1;
    [Range(0.01f, 3f)] public float fireRate = 1.0f;
    [Range(0.01f, 5f)] public float spreadRate = 0.5f;
    public int maxBulletAmount = 30;
    public int maxAmmoInCartriges = 90;
    public int currentAmmo = 0;
    public int currentInCartriges = 90;
    public float damage = 2f;
    public float impactForce = 2f;
    public float nextTimeToFire = 0f;
    public float shakeAmount = 1f;

    public WeaponData(string weaponName = "Weapon Name", int weaponIndex = -1, float fireRate = 1.0f, float spreadRate = 0.5f, int maxBulletAmount = 30, int maxAmmoInCartriges = 90, int currentAmmo = 0, int currentInCartriges = 90, float damage = 2f, float impactForce = 2f, float shakeAmount = 1f)
    {
        this.weaponName = weaponName;
        this.weaponIndex = weaponIndex;
        this.fireRate = fireRate;
        this.spreadRate = spreadRate;
        this.maxBulletAmount = maxBulletAmount;
        this.maxAmmoInCartriges = maxAmmoInCartriges;
        this.currentAmmo = currentAmmo;
        this.currentInCartriges = currentInCartriges;
        this.damage = damage;
        this.impactForce = impactForce;
        this.shakeAmount = shakeAmount;
    }
}

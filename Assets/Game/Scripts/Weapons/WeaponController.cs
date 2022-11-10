using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public WeaponData weapon;
    public GameObject weaponPrefab;
    public Transform bulletSpawner;
    public ParticleSystem[] muzzleFX;
    public ParticleSystem[] impactFX;
    public TrailRenderer trailFx;
    public AudioClip[] fireAudio;
    public AudioClip[] reloadAudio;
    public float shakeDuration;
    public float shakeMagnitude;
    public WeaponState state;
    public Vector3 idlePosition;
    public Vector3 aimPosition;
    public AudioSource source;

    public enum WeaponState
    {
        Start_Holster,
        Idle,
        Shoot,
        Aiming_Start,
        Aiming_Idle,
        Aiming_Shoot,
        Aiming_Stop,
        Meelee,
        End_Holster
    }
}

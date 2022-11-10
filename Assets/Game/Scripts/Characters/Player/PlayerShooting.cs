using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float timeBetweenShots = .3333f;
    private float m_timestamp = 0f;

    private void FixedUpdate()
    {
        if((Time.time >= m_timestamp) && (Input.GetKey(KeyCode.Mouse0)))
        {
            Fire();
            m_timestamp = Time.time + timeBetweenShots;
        }
    }

    private void Fire()
    {
        if(bulletPrefab == null)
        {
            return;
        }
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
        Destroy(bullet, 2f);
        CinemachineShake.Instance.ShakeCamera(.2f, .1f);
    }
}

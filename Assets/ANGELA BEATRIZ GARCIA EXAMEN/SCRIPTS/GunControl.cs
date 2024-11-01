using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GunControl : MonoBehaviour
{

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public float fireRate = 1f; 

    private float nextFireTime = 0f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate; 
            Shoot();
        }
    }

    void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation * Quaternion.Euler(90f, 0f, 0f));
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }

}


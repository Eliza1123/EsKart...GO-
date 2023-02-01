using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public int bulletCount = 0;

    private void Update()
    {
        Timer timer = new Timer();
        if (bulletCount != 10)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                bulletCount++;
            }
        }
    }
}

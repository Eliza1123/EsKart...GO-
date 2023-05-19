using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class GunThick : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public int bulletCount = 0;
    public int bulletCountTwo = 0;
    public int bulletTwoSlow = 1 / 2;

    private void Update()
    {
        Timer timer = new Timer();
        if (bulletCountTwo != 10)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                var bulletTwo = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bulletTwo.transform.Rotate(0, 90, 0);
                bulletTwo.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed / 2;
                bulletCountTwo++;
            }
        }
 
    }
}
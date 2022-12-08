using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    public float speedMultiplier = 1.4f;
    public float speedDuration = 4f;

    public GameObject pickupEffect;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        //Debug.Log("Power up picked up!");

        //Instantiate(pickupEffect, transform.position, transform.rotation);

        CarDrive accel = player.GetComponent<CarDrive>();
        accel.speed *= speedMultiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(speedDuration);

        accel.speed /= speedMultiplier;

        Destroy(gameObject);
    }

}

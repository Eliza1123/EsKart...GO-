using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePowerUp : MonoBehaviour
{
    public float multiplier = 1.4f;
    public float duration = 4f;

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

        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.damage *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        stats.damage /= multiplier;

        Destroy(gameObject);
    }



}

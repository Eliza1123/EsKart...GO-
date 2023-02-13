using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunPowerup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Destroy(gameObject);
       
    }
}

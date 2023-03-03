using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunThickPowerup : MonoBehaviour
{
    public GunThick GunThick;
    public float durationThick = 11f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PickupThick());
        }
    }

    IEnumerator PickupThick()
    {

        GunThick.bulletCountTwo = 0;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(durationThick);

        Destroy(gameObject);

    }

    //IEnumerator PowerupSpawnRoutine()
    //{

    // }
}

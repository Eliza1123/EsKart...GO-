using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunPowerup : MonoBehaviour
{
    public Gun Gun;
    public float duration = 11f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup());
        }
    }

    IEnumerator Pickup()
    {
        Debug.Log("registered pickup");
        Gun.bulletCount = 0;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        Destroy(gameObject);
       
    }

    //IEnumerator PowerupSpawnRoutine()
    //{

   // }
}

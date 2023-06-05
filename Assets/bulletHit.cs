using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Bullet"))
        {
            Debug.Log("hit detected");
            
        }
        
    }
}

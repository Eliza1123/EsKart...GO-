using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit detected");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int health;

    public HealthBar healthBar;

    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Debug.Log("Q key pressed");
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage) 
    {
        health -= damage;

        healthBar.SetHealth(health);
    }
}

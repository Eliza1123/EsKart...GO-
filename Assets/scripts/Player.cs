using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Initializing game");
        currentHealth = maxHealth;
        //Debug.Log("current health = " + currentHealth);
        healthBar.SetMaxHealth(maxHealth);
        //Debug.Log("Error fixed");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            //Debug.Log("Q key pressed");
            TakeDamage(20);
            //Debug.Log("Took damage");
        }
    }

    void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        if (currentHealth >= 0)
        {
            //Debug.Log("current health is " + currentHealth);
            healthBar.SetHealth(currentHealth);
        }

        else 
        {
            Debug.Log("You are dead, current health is " + currentHealth);
        }
        
    }
}

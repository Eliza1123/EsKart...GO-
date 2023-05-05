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
        Debug.Log("Initializing game or something idk");
        currentHealth = maxHealth;
        Debug.Log("health was set to max");
        healthBar.SetMaxHealth(maxHealth);
        Debug.Log("you suck at coding");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Debug.Log("Q key pressed");
            TakeDamage(20);
            Debug.Log(";(");
        }
    }

    void TakeDamage(int damage) 
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}

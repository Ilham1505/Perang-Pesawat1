using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class building : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public healthBar HealthBar;

    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.setHealth(maxHealth);
    }

    public void takeDamage (int damage)
    {
        currentHealth -= damage;
        HealthBar.setHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}

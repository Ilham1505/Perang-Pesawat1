using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currentHealth;
    public healthBar HealthBar;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        HealthBar.setHealth(maxHealth);
    }

    public void takeDamage (int damage)
    {
        currentHealth -= damage;
        HealthBar.setHealth(currentHealth);
        if (currentHealth <= 0 )
        {
            anim.Play("exploision");
            Destroy(gameObject,1.0f);
        }
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
     {
         if (hitInfo.gameObject.tag == "Wall")
         {
            anim.Play("exploision");
            Destroy(gameObject,1.0f);
         }
     }
}

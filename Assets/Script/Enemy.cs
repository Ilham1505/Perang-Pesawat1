using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public healthBar HealthBar;
    private Animator anim;
    public GameObject other;

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
        if (currentHealth <= 0)
        {
            anim.Play("exploision");
            Destroy(other);
            Destroy(gameObject,1.0f);
        }
    }
    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Building")
        {
            this.GetComponent<EdgeCollider2D>().enabled = false;
        }
    }
}

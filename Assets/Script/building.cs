using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class building : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public healthBar HealthBar;
    private Animator anim;
    public Text score;
    private int scoreNum;



    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        HealthBar.setHealth(maxHealth);
        scoreNum = 0;
        score.text = " Score : " + scoreNum ; 
    }

    public void takeDamage (int damage)
    {
        currentHealth -= damage;
        HealthBar.setHealth(currentHealth);
        if (currentHealth <= 0)
        {
            scoreNum += 10;
            score.text = "Score : " + scoreNum ;
            anim.Play("exploision");
            Destroy(gameObject, 1.0f);
        }
    }

}

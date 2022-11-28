using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5000;
    public int damage = 50;
    public Rigidbody2D rb;

    void Update()
    {
        rb.velocity = transform.up * Time.deltaTime * speed;
    }

    
     void OnTriggerEnter2D (Collider2D hitInfo)
     {
         Enemy enemy = hitInfo.GetComponent<Enemy>();
         if (enemy != null)
         {
             enemy.takeDamage(damage);
         }
         Destroy(gameObject);
     }
    
}

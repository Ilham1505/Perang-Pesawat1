using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public float speed = 5000;
    public int damage = 50;
    public Rigidbody2D rb;
    private Animator anim;



    void Start()
    {
        rb.velocity = transform.up * Time.deltaTime * speed;
    }
    void Update()
    {
        anim = GetComponent<Animator>();
    }

     void OnTriggerEnter2D (Collider2D hitInfo)
     {
        rb.velocity = transform.up * Time.deltaTime * 0;
        building Building = hitInfo.GetComponent<building>();
        if (Building != null)
        {
            anim.Play("exploision");
            Destroy(gameObject, 1.0f);
            Building.takeDamage(damage);
        }
     }
}

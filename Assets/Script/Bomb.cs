using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public float speed = 0;
    public int damage = 50;
    public Rigidbody2D rb;
    public float dropTime = 4;
    private Animator anim;


    void Update()
    {
        anim = GetComponent<Animator>();
        rb.velocity = transform.up * Time.deltaTime * speed;
    }

    
     void OnTriggerEnter2D (Collider2D hitInfo)
     {
         building Building = hitInfo.GetComponent<building>();
         if (Building != null)
         {
            StartCoroutine(wait());
            //Building.takeDamage(damage);
            //Destroy(gameObject);
         }
        IEnumerator wait()
        {
        yield return new WaitForSecondsRealtime(dropTime);
        Building.takeDamage(damage);
        anim.Play("exploision");
        Destroy(gameObject, 1.0f);
        }
     }
    
}

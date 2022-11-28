using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float speed = 0;
    public int damage = 50;
    public Rigidbody2D rb;
    public float dropTime = 10;


    void Start()
    {

    }
    void Update()
    {
        //StartCoroutine(bombDrop());
        rb.velocity = transform.up * Time.deltaTime * speed;
    }

    
     void OnTriggerEnter2D (Collider2D hitInfo)
     {
         building Building = hitInfo.GetComponent<building>();
         if (Building != null)
         {
            StartCoroutine(wait());
            Building.takeDamage(damage);         
            //Destroy(gameObject);
         }
     }

    private IEnumerator bombDrop()
    {
        this.GetComponent<EdgeCollider2D>().enabled = false;
        yield return new WaitForSecondsRealtime(dropTime);
        this.GetComponent<EdgeCollider2D>().enabled = true;
    }

    private IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(dropTime);
        //Building.takeDamage(damage);         
        Destroy(gameObject);
    }
    
}

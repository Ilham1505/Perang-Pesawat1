using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotateSpeed = 2.0f;
    Rigidbody2D rb;  
    public int hp;    
    // Start is called before the first frame update
    void Start()
    {
          rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        movement();

    }

    void movement()
    {
        float belok = Input.GetAxis("Horizontal");
        if (belok != 0)
        {
            transform.Rotate(0, 0, -belok * rotateSpeed);
        }

        rb.AddForce(transform.up * speed);
    }

    /*void decreaseHp()
    {
        if()
        hp = hp;
    }*/

}

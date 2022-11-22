using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sc : MonoBehaviour
{
    [SerializeField]private Slider _slider;


    public float speed = 5.0f;
    public float rotateSpeed = 2.0f;
    Rigidbody2D rb;  
    public int hp;  
    private bool left;
    private bool right;



    void Start()
    {
          rb = GetComponent<Rigidbody2D>();
          left = false;
          right = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        movementHorizontal();

    }
    public void PointerDownLeft()
    {
        left = true;
    }

    public void PointerUpLeft()
    {
        left = false;
    }

    public void PointerDownRight()
    {
        right = true;
    }

    public void PointerUpRight()
    {
        right = false;
    }

    /*public void movement()
    {
        float belok = Input.GetAxis("Horizontal");
        if (belok != 0)
        {
            transform.Rotate(0, 0, rotateSpeed);
        }

        rb.AddForce(transform.up * speed);
    }*/

    public void movementHorizontal()
    {
        if (left)
        {
            transform.Rotate(0, 0, rotateSpeed);
        }
        else if (right)
        {
            transform.Rotate(0, 0, -rotateSpeed);
        }

        rb.AddForce(transform.up * speed);
    }

   public void increaseSpeed(float newSpeed)
    {
        speed = newSpeed;
    }



    /*void decreaseHp()
    {
        if()
        hp = hp;
    }*/

}

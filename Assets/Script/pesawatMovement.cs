using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesawatMovement : MonoBehaviour
{
    public float speed= 5f;
    private Rigidbody2D rb;

    private Vector2 playerDirection;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       float directionX = Input.GetAxisRaw("Horizontal");
       playerDirection = new Vector2(directionX, 0).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2( playerDirection.x * speed, 0);
    }
    
}

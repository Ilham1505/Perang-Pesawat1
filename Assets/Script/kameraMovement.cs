using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraMovement : MonoBehaviour
{
    public float speed= 5f;
    public Rigidbody2D rb;
    public GameObject Pesawat;
    public float currentXPosition;
    public float currentYPosition;
    //public float turnSpeed;

    private Vector2 playerDirection;
    //Vector2 movement;
    public float cameraSpeed;


    void Start()
    {
        currentYPosition = Pesawat.transform.position.y;
        currentXPosition = Pesawat.transform.position.x;
        turnForward();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       //print(currentYPosition);
       //print(currentXPosition);
        //transform.position += new Vector3(0, cameraSpeed * Time.deltaTime, 0);
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //playerDirection = new Vector3(0,cameraSpeed * Time.deltaTime, 0).normalized;
        //turnForward();
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            manuverRight();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            manuverLeft();
    }

    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        rb.velocity = new Vector2( playerDirection.x * speed, playerDirection.y * speed);
        //rb.velocity = new Vector2( 0, playerDirection.y * speed);
    }

    void halfRightTurnRight()
    {
        playerDirection = new Vector3(cameraSpeed , cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, -90, -90);
    }

    void halfDownTurnRight()
    {
        playerDirection = new Vector3(cameraSpeed , -cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, -90, -90);
    }

    void halfUpTurnRight()
    {
        playerDirection = new Vector3(-cameraSpeed , cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, -90, -90);
    }

    void halfLeftTurnRight()
    {
        playerDirection = new Vector3(-cameraSpeed , -cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, 90, 90);
    }

    void halfRightTurnLeft()
    {
        playerDirection = new Vector3(cameraSpeed , -cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, -90, -90);
    }

    void halfDownTurnLeft()
    {
        playerDirection = new Vector3(-cameraSpeed , -cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, -90, -90);
    }

    void halfUpTurnLeft()
    {
        playerDirection = new Vector3(cameraSpeed , cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, -90, -90);
    }

    void halfLeftTurnLeft()
    {
        playerDirection = new Vector3(-cameraSpeed , cameraSpeed, 0).normalized;
        transform.rotation = Quaternion.Euler(0, 90, 90);
    }

    void turnRight()
    {
        playerDirection = new Vector3(cameraSpeed , 0, 0).normalized;
        transform.rotation = Quaternion.Euler(0, 0, -90);
        //transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, -90), turnSpeed);
        //transform.Rotate(0, 0, -90);
    }

    void turnLeft()
    {
        playerDirection = new Vector3(-cameraSpeed , 0, 0).normalized;
        transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    void turnBackward()
    {
        playerDirection = new Vector3(0,-cameraSpeed , 0).normalized;
        transform.rotation = Quaternion.Euler(0, 0, 180);
    }

    void turnForward()
    {
        playerDirection = new Vector3(0,cameraSpeed , 0).normalized;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    void manuverRight()
    {
        if(Pesawat.transform.position.y > currentYPosition)
            {
                halfRightTurnRight();
                StartCoroutine(right());
                //currentYPosition = Pesawat.transform.position.y;
            }
        if (Pesawat.transform.position.x > currentXPosition)
            {
                halfDownTurnRight();
                StartCoroutine(down());
                //currentXPosition = Pesawat.transform.position.x;
            }
        if(Pesawat.transform.position.y < currentYPosition)
            {
                halfLeftTurnRight();
                StartCoroutine(left());
                //currentYPosition = Pesawat.transform.position.y;
            }
        if (Pesawat.transform.position.x < currentXPosition)
            {
                halfUpTurnRight();
                StartCoroutine(up());
                //currentXPosition = Pesawat.transform.position.x;
            }
    }
    void manuverLeft()
    {
        if(Pesawat.transform.position.y > currentYPosition)
        {
                halfLeftTurnLeft();
                StartCoroutine(left());
                //currentYPosition = Pesawat.transform.position.y;
        }
        if (Pesawat.transform.position.x < currentXPosition)
        {
                halfDownTurnLeft();
                StartCoroutine(down());
                //currentXPosition = Pesawat.transform.position.x;
        }
        if(Pesawat.transform.position.y < currentYPosition)
        {
                halfRightTurnLeft();
                StartCoroutine(right());
                //currentYPosition = Pesawat.transform.position.y;
        }
        if (Pesawat.transform.position.x > currentXPosition)
        {
                halfUpTurnLeft();
                StartCoroutine(up());
                //currentXPosition = Pesawat.transform.position.x;
        }
    }
    private IEnumerator right()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        turnRight();
        currentYPosition = Pesawat.transform.position.y;
    }
    private IEnumerator left()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        turnLeft();
        currentYPosition = Pesawat.transform.position.y;
    }
    private IEnumerator up()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        turnForward();
        currentXPosition = Pesawat.transform.position.x;
    }
    private IEnumerator down()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        turnBackward();
        currentXPosition = Pesawat.transform.position.x;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryBullet : MonoBehaviour
{
    public float interval;
    
    void Start()
    {
        Destroy (gameObject,interval);
    }
    void OnTriggerEnter2D (Collider2D hitInfo)
     {
         if (hitInfo.gameObject.tag == "Wall")
         {
            Destroy(gameObject);
         }
     }
}

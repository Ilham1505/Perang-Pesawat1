using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalingMuter : MonoBehaviour
{
    [SerializeField]private int speed = 100;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,Time.deltaTime * speed, 0);
    }
}

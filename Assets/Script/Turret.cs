using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float timer;
    public float ShootInterval = 0.5f;
    bool shooting ;


    public void shootActive()
    {
        shooting = true;
    }

    public void shootDeactive()
    {
        shooting = false;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= ShootInterval)
        {
            Shoot();
            timer = 0;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

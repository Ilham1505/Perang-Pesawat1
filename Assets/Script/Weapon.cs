using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float timer;
    public float ShootInterval = 0.5f;
    bool shooting ;
    // Start is called before the first frame update
    void Start()
    {

          }

    // Update is called once per frame


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
        if (shooting && timer >= ShootInterval)
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

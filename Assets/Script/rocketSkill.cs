using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketSkill : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float cooldownTime;
    private bool notCd = true;

    bool shooting ;
  
    public void shootActive()
    {
        shooting = true;
    }

    public void shootDeactive()
    {
        shooting = false;
    }

    private IEnumerator cooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        notCd = true;
    }

    void Update()
    {
        skillUse();
    }

    void skillUse()
    {

        if(shooting && notCd == true)
        {
            notCd = false;
            Shoot();
            StartCoroutine(cooldown());
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        shooting = false;
    }
}

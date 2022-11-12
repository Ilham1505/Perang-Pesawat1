using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodgeSkill : MonoBehaviour
{
    // Start is called before the first frame update

    private bool notCd = true;

    public float cooldownTime;

    public float skillTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        skillUse();
    }

    private IEnumerator dodge()
    {
        this.GetComponent<EdgeCollider2D>().enabled = false;
        yield return new WaitForSecondsRealtime(skillTime);
        this.GetComponent<EdgeCollider2D>().enabled = true;
    }

    private IEnumerator cooldown()
    {
        yield return new WaitForSeconds(cooldownTime+skillTime);
        notCd = true;
    }

    void skillUse()
    {
        if (Input.GetKeyDown(KeyCode.Space) && notCd == true)
        {
            notCd = false;
            StartCoroutine(dodge());
            StartCoroutine(cooldown());
        }
    }

}

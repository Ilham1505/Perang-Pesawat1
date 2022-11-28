using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodgeSkill : MonoBehaviour
{
    // Start is called before the first frame update

    private bool notCd = true;

    public float cooldownTime;

    public float skillTime;
    
    public bool Skill;


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

    public void skillActive()
    {
        Skill = true;
    }

    public void skillDeactive()
    {
        Skill = false;
    }

    void skillUse()
    {

        //if (Input.GetKeyDown(KeyCode.Space) && notCd == true)
        if(Skill)
        {
            notCd = false;
            StartCoroutine(dodge());
            StartCoroutine(cooldown());
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodgeSkill : MonoBehaviour
{
    // Start is called before the first frame update

    private bool notCd = true;

    public float cooldownTime;
    public GameObject other;

    public float skillTime;
    private Animator anim;
    public bool Skill;
    private int speed = 100;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        skillUse();
    }

    private IEnumerator dodge()
    {
        this.GetComponent<EdgeCollider2D>().enabled = false;
        anim.Play("dodge");
        yield return new WaitForSecondsRealtime(skillTime);
        anim.Play("idlestrike");
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

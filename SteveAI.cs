using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SteveAI : MonoBehaviour
{

    public GameObject SteveDestination;
    NavMeshAgent SteveAgent;
    public GameObject SteveEnemy;
    public static bool isStalking;
    public bool AttackTrigger = false;
    public bool isAttacking = false;
    public AudioSource HurtSound1;
    public AudioSource HurtSound2;
    public AudioSource HurtSound3;
    public int HurtGen;
    public GameObject HurtFlash;
    void Start()
    {
        SteveAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStalking == false)
        {
            SteveEnemy.GetComponent<Animator>().Play("idle");
        }
        else
        {
            
            if (AttackTrigger == true && isAttacking == false)
            {
                SteveEnemy.GetComponent<Animator>().Play("attack");
                StartCoroutine(InflictDamage());
            }
            else
            {
                SteveAgent.SetDestination(SteveDestination.transform.position);
                SteveEnemy.GetComponent<Animator>().Play("walk");
            }
        }

    }
    void OnTriggerEnter()
    {
        AttackTrigger = true;
    }

    void OnTriggerExit()
    {
        AttackTrigger = false;
    }

    IEnumerator InflictDamage()
    {
        isAttacking = true;
        HurtGen = Random.Range(1, 4);
        if (HurtGen == 1)
        {
            HurtSound1.Play();
        }
        if (HurtGen == 2)
        {
            HurtSound2.Play();
        }
        if (HurtGen == 3)
        {
            HurtSound3.Play();
        }
        GlobalHealth.currentHealth -= 10;
        HurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        HurtFlash.SetActive(false);
        yield return new WaitForSeconds(1.4f);
        isAttacking = false;

    }
}

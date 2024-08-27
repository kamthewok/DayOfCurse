using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAI : MonoBehaviour
{

    public GameObject BossDestination;
    NavMeshAgent BossAgent;
    public GameObject BossEnemy;
    public GameObject BossEnemyNMA;
    public bool AttackTrigger = false;
    public bool isAttacking = false;
    public AudioSource HurtSound1;
    public AudioSource HurtSound2;
    public AudioSource HurtSound3;
    public int HurtGen;
    public GameObject HurtFlash;
    
    
    void Start()
    {
        BossAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
            if (AttackTrigger == true && isAttacking == false)
            {
                BossEnemyNMA.GetComponent<NavMeshAgent>().speed = 0;
                BossEnemy.GetComponent<Animation>().Play("Zombie Attack");
                StartCoroutine(InflictDamage());
            }
            if (AttackTrigger == false)
            {
            BossEnemyNMA.GetComponent<NavMeshAgent>().speed = 5.8f;
            BossAgent.SetDestination(BossDestination.transform.position);
            BossEnemy.GetComponent<Animation>().Play("Zombie Run");
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

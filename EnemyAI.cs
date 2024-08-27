using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public float EnemySpeed = 0.015f;
    public bool AttackTrigger = false;
    public bool isAttacking = false;
    public AudioSource HurtSound1;
    public AudioSource HurtSound2;
    public AudioSource HurtSound3;
    public int HurtGen;
    public GameObject HurtFlash;

    void Update()
    {
        transform.LookAt(Player.transform);
        if(AttackTrigger == false)
        {
            EnemySpeed = 0.015f;
            Enemy.GetComponent<Animation>().Play("Zombie Running");
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
        }
        if(AttackTrigger == true && isAttacking == false)
        {
            EnemySpeed = 0;
            Enemy.GetComponent<Animation>().Play("Zombie Attack");
            StartCoroutine(InflictDamage());
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
        GlobalHealth.currentHealth -= 5;
        HurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        HurtFlash.SetActive(false);
        yield return new WaitForSeconds(1.4f);
        isAttacking = false;

    }

}

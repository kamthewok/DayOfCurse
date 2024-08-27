using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject Enemy;
    public int StatusCheck;
    public AudioSource ZombieDeathSound;

    void DamageEnemy (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }



    void Update()
    {
        if(EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<EnemyAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            Enemy.GetComponent<Animation>().Stop("Zombie Running");
            Enemy.GetComponent<Animation>().Play("Zombie Death");
            ZombieDeathSound.Play();
            Enemy.GetComponent<BoxCollider>().enabled = false;
        }
    }
}

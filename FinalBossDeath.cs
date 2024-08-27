using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBossDeath : MonoBehaviour
{
    public int EnemyHealth = 210;
    public GameObject Enemy;
    public int StatusCheck;
    public AudioSource ZombieDeathSound;
    public GameObject Key;

    void DamageEnemy (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }



    void Update()
    {
        if(EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<BossAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            Enemy.GetComponent<Animation>().Stop("Zombie Run");
            Enemy.GetComponent<Animation>().Play("Sword And Shield Death 1");
            ZombieDeathSound.Play();
            Key.SetActive(true);
        }
    }
}

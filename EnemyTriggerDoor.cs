using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerDoor : MonoBehaviour
{
    public AudioSource DoorJumpScareSound;
    public AudioSource JumpScareMusic;
    public GameObject Enemy;
    public GameObject DoorJumpScare;
    public GameObject ZombieEnemy;

   void OnTriggerEnter()
    {
        
        GetComponent<BoxCollider>().enabled = false;
        DoorJumpScare.GetComponent<Animation>().Play("JumpScareAnimation");
        DoorJumpScareSound.Play();
        ZombieEnemy.SetActive(true);
        Enemy.SetActive(true);
        StartCoroutine(PlayJumpScareMusic());
    }

    IEnumerator PlayJumpScareMusic()
    {
        yield return new WaitForSeconds(0.15f);
        JumpScareMusic.Play();
    }

    

}

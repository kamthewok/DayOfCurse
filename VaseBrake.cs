using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBrake : MonoBehaviour
{
    public GameObject FakeVase;
    public GameObject BrokenVase;
    public GameObject Sphere;
    public AudioSource VaseBrakeSound;
    public GameObject Key;
    public GameObject KeyTrigger;



    void DamageEnemy(int DamageAmount)
    {
        StartCoroutine(BrakeVase());
    }


    IEnumerator BrakeVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        VaseBrakeSound.Play();
        Key.SetActive(true);
        KeyTrigger.SetActive(true);
        FakeVase.SetActive(false);
        BrokenVase.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        Sphere.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        Sphere.SetActive(false);
    }
}

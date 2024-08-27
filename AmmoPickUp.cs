using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{

    public GameObject Ammo;
    public GameObject ammoDisplayBox;
    public AudioSource AmmoPickUpSound;

    void OnTriggerEnter(Collider other)
    {
        ammoDisplayBox.SetActive(true);
        GlobalAmmo.ammoCount += 7;
        AmmoPickUpSound.Play();
        Ammo.SetActive(false);
    }
}

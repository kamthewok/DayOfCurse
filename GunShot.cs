using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public GameObject Gun;
    public GameObject FlashPistol;
    public AudioSource GunShotSound;
    public bool IsFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;

    void Update()
    {
        if (Input.GetButton("Fire1") && GlobalAmmo.ammoCount >= 1)
        {
            if(IsFiring == false)
            {
                GunShotSound.Stop();
                GlobalAmmo.ammoCount -= 1;
                StartCoroutine(FiringPistol());
            }
        }
    }

    IEnumerator FiringPistol()
    { 
        RaycastHit Shot;
        IsFiring = true;
        if(Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageEnemy", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        Gun.GetComponent<Animation>().Play("Shot");
        FlashPistol.SetActive(true);
        FlashPistol.GetComponent<Animation>().Play("FlashAnimation");
        GunShotSound.Play();
        yield return new WaitForSeconds(0.3f);
        FlashPistol.SetActive(false);
        IsFiring = false;
    }


}

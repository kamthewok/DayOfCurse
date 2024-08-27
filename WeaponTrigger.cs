using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

public class WeaponTrigger : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject Arrow;
    public AudioSource Dialog02;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<Text>().text = "Hmmm...raczej nie bêdzie tego potrzebowa³";
        Dialog02.Play();
        Arrow.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        TextBox.GetComponent<Text>().text = "";
        
    }

}

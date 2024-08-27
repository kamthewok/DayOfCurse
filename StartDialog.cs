using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class StartDialog: MonoBehaviour
{

    public GameObject Player;
    public GameObject StartTransition;
    public GameObject TextBox;
    public AudioSource Dialog01;
    

    void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;
        TextBox.GetComponent<Text>().enabled = false;
        StartCoroutine(ScenePlayer());

        IEnumerator ScenePlayer()
        {
           
            yield return new WaitForSeconds(2);
            TextBox.GetComponent<Text>().enabled = true;
            StartTransition.SetActive(false);
            TextBox.GetComponent<Text>().text = "Oh...moja g³owa. Muszê siê st¹d wydostaæ.";
            Dialog01.Play();
            yield return new WaitForSeconds(5);
            TextBox.GetComponent<Text>().text = "";
            Player.GetComponent<FirstPersonController>().enabled = true;
        }

        
    }


}

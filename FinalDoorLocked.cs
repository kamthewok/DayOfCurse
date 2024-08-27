using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class FinalDoorLocked : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ObjectCrosshair;
    public GameObject FadeOut;
    public AudioSource LockedDoor;
    public GameObject Player;
    public GameObject HPPanel;
    public GameObject KeyPanel;
    public GameObject AmmoPanel;


    // Update is called once per frame
    void Update()
    {
        Distance = PlayerAction.DistanceFromPoint;
    }

    void OnMouseOver()
    {
        if(Distance <= 2.5)
        {
            
            ObjectCrosshair.SetActive(true);
            ActionText.GetComponent<Text>().text = "Otwórz drzwi. Wymagany klucz.";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if(Input.GetButtonDown("Action"))
        {
            if(Distance <= 2.5 && GlobalInventory.KeysCount == 0)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ObjectCrosshair.SetActive(false);
                StartCoroutine(DoorReset());
            }

            if (Distance <= 2.5 && GlobalInventory.KeysCount > 0)
            {
                StartCoroutine(Ending());
                //SceneManager.LoadScene(0);
            }
        }
    }

    void OnMouseExit()
    {
        ObjectCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator Ending()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;
        HPPanel.SetActive(false);
        KeyPanel.SetActive(false);
        AmmoPanel.SetActive(false);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(0);
    }


    IEnumerator DoorReset()
    {
        LockedDoor.Play();
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}

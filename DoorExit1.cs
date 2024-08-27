using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorExit1 : MonoBehaviour
{
    public float Distance; 
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ObjectCrosshair;
    public GameObject FadeOut;

    // Update is called once per frame
    void Update()
    {
        Distance = PlayerAction.DistanceFromPoint;
    }

    void OnMouseOver()
    {
        if(Distance <= 2.5)
        {
            ActionText.GetComponent<Text>().text = "Naciœnij, aby otworzyæ drzwi.";
            ObjectCrosshair.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }

        if(Input.GetButtonDown("Action"))
        {
            if(Distance <= 2.5)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                FadeOut.SetActive(true);
                StartCoroutine(FadeExit());
                
            }
        }
    }

    void OnMouseExit()
    {
        ObjectCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }


    IEnumerator FadeExit()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
    }
}

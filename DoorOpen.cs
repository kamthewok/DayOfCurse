using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Door;
    public AudioSource DoorSound;
    public GameObject ObjectCrosshair;

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
                Door.GetComponent<Animation>().Play("DoorOpeningAnimation");
                DoorSound.Play();
            }
        }
    }

    void OnMouseExit()
    {
        ObjectCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}

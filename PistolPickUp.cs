using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PistolPickUp : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject PistolFake;
    public GameObject PistolPlayer;
    public GameObject ArrowPoint;
    public GameObject ObjectCrosshair;
    public GameObject EnemyTrigger;
    public GameObject PistolSound;
    
    
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
            ActionText.GetComponent<Text>().text = "Naciœnij, aby podnieœæ broñ.";
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
                PistolFake.SetActive(false);
                PistolPlayer.SetActive(true);
                PistolSound.SetActive(true);
                ObjectCrosshair.SetActive(false);
                ArrowPoint.SetActive(false);
                EnemyTrigger.SetActive(true);
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

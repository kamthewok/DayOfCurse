using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickUp : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ObjectCrosshair;
    public GameObject TheKey;
    
    // Update is called once per frame
    void Update()
    {
        Distance = PlayerAction.DistanceFromPoint;
    }

    void OnMouseOver()
    {
        if(Distance <= 3.5)
        {
            
            ObjectCrosshair.SetActive(true);
            ActionText.GetComponent<Text>().text = "Naciœnij, aby podnieœæ klucz";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if(Input.GetButtonDown("Action"))
        {
            if(Distance <= 3.5)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ObjectCrosshair.SetActive(false);
                TheKey.SetActive(false);
                GlobalInventory.KeysCount += 1;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzelPlacement : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ObjectCrosshair;
    public GameObject PuzzleParts;
    public GameObject HalfFade;
    public GameObject RealWall;

    // Update is called once per frame
    void Update()
    {
        Distance = PlayerAction.DistanceFromPoint;
    }

    void OnMouseOver()
    {
        if (GlobalInventory.LeftPuzzle == true && GlobalInventory.RightPuzzle == true)
        {

            if (Distance <= 3.5)
            {

                ObjectCrosshair.SetActive(true);
                ActionText.GetComponent<Text>().text = "Naciœnij, aby po³o¿yæ czêœci uk³adanki";
                ActionDisplay.SetActive(true);
                ActionText.SetActive(true);
            }

            if (Input.GetButtonDown("Action"))
            {
                if (Distance <= 3.5)
                {
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionDisplay.SetActive(false);
                    ActionText.SetActive(false);
                    ObjectCrosshair.SetActive(false);
                    PuzzleParts.SetActive(true);
                    RealWall.GetComponent<Animator>().Play("RealOpen");
                }
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

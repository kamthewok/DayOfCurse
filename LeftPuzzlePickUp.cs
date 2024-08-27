using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftPuzzlePickUp : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ObjectCrosshair;
    public GameObject LeftPuzzle;
    public GameObject HalfFade;
    public GameObject LeftPuzzleImg;
    public GameObject LeftPuzzleText;

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
            ActionText.GetComponent<Text>().text = "Naciœnij, aby podnieœæ lew¹ czêœæ";
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
                GlobalInventory.LeftPuzzle = true;
                StartCoroutine(PuzzlePickUp());
            }
        }
    }

    void OnMouseExit()
    {
        ObjectCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator PuzzlePickUp()
    {
        HalfFade.SetActive(true);
        LeftPuzzleImg.SetActive(true);
        LeftPuzzleText.SetActive(true);
        yield return new WaitForSeconds(2);
        HalfFade.SetActive(false);
        LeftPuzzleImg.SetActive(false);
        LeftPuzzleText.SetActive(false);
        LeftPuzzle.SetActive(false);
    }
    
}

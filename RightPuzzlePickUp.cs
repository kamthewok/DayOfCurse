using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightPuzzlePickUp : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ObjectCrosshair;
    public GameObject RightPuzzle;
    public GameObject HalfFade;
    public GameObject RightPuzzleImg;
    public GameObject RightPuzzleText;
    public GameObject FakeWall;
    public GameObject RealWall;

    // Update is called once per frame
    void Update()
    {
        Distance = PlayerAction.DistanceFromPoint;
    }

    void OnMouseOver()
    {
        if (Distance <= 3.5)
        {

            ObjectCrosshair.SetActive(true);
            ActionText.GetComponent<Text>().text = "Naciœnij, aby podnieœæ praw¹ czêœæ uk³adanki";
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
                GlobalInventory.RightPuzzle = true;
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
        FakeWall.SetActive(false);
        RealWall.SetActive(true);
        RightPuzzleText.GetComponent<Text>().text = "Zdoby³eœ praw¹ czêœæ uk³adanki";
        HalfFade.SetActive(true);
        RightPuzzleImg.SetActive(true);
        RightPuzzleText.SetActive(true);
        yield return new WaitForSeconds(2);
        HalfFade.SetActive(false);
        RightPuzzleImg.SetActive(false);
        RightPuzzleText.SetActive(false);
        RightPuzzle.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverToMainMenu : MonoBehaviour
{

    public GameObject FadeOut;
    public GameObject LoadText;


    void Start ()
    {
        StartCoroutine(ToMenuStart());

    }

    IEnumerator ToMenuStart()
    {
        yield return new WaitForSeconds(5);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        LoadText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject FadeOut;
    public GameObject LoadText;
    public AudioSource ButtonClick;
    public GameObject LoadButton;
    public int LoadInt;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        LoadInt = PlayerPrefs.GetInt("AutoSave");
        if (LoadInt > 0)
        {
            LoadButton.SetActive(true);
        }
    }


    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());

    }

    IEnumerator NewGameStart()
    {
        FadeOut.SetActive(true);
        ButtonClick.Play();
        yield return new WaitForSeconds(3);
        LoadText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

    public void LoadGameButton()
    {
        StartCoroutine(LoadGameStart());

    }

    IEnumerator LoadGameStart()
    {
        GlobalHealth.currentHealth = 100;
        GlobalAmmo.ammoCount = 0;
        GlobalInventory.KeysCount = 0;
        FadeOut.SetActive(true);
        ButtonClick.Play();
        yield return new WaitForSeconds(3);
        LoadText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(LoadInt);
        
    }

    public void ExitGameButton()
    {
        StartCoroutine(ExitGameStart());

    }

    IEnumerator ExitGameStart()
    {
        FadeOut.SetActive(true);
        ButtonClick.Play();
        yield return new WaitForSeconds(3);
        Application.Quit();

    }
}

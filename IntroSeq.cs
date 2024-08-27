using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSeq : MonoBehaviour
{

    public GameObject TextBox;
    public AudioSource ThudSound;
    public GameObject BlackScreen;
    public GameObject LoadingText;

    void Start()
    {
        StartCoroutine(SeqBegin());
        
    }

    IEnumerator SeqBegin()
    {
        LoadingText.SetActive(false);
        yield return new WaitForSeconds(1);
        TextBox.SetActive(true);
        yield return new WaitForSeconds(23);
        TextBox.SetActive(false);
        BlackScreen.SetActive(true);
        ThudSound.Play();
        yield return new WaitForSeconds(1);
        LoadingText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);


    }
    
}

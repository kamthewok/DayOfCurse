using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public static int currentHealth = 100;
    public GameObject HealthPointsDisplay;
    public int internalHealth;

    void Update()
    {
        internalHealth = currentHealth;
        HealthPointsDisplay.GetComponent<Text>().text = "" + currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}

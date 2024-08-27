using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalInventory : MonoBehaviour
{
    public static int KeysCount;
    public GameObject KeysDisplay;
    public int internalKeys;
    public static bool LeftPuzzle = false;
    public static bool RightPuzzle = false;
    
    void Update()
    {
        internalKeys = KeysCount;
        KeysDisplay.GetComponent<Text>().text = "" + KeysCount;

    }
}

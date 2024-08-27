using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int ammoCount = 0;
    public GameObject ammoDisplay;
    public int internalAmmo;
    // Update is called once per frame
    void Update()
    {
        internalAmmo = ammoCount;
        ammoDisplay.GetComponent<Text>().text = "" + ammoCount;
        
    }
}

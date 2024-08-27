using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LampAnimations : MonoBehaviour
{
    public int ModeForLights;
    public GameObject LampLight;


    // Update is called once per frame
    void Update()
    {
        if (ModeForLights == 0)
        {
            StartCoroutine(AnimateLight());
        }
    } 
        IEnumerator AnimateLight()
        {
            ModeForLights = Random.Range(1, 4);
            if(ModeForLights == 1)
            {
                LampLight.GetComponent<Animation>().Play("LampAnimation001");
            }
            if (ModeForLights == 2)
            {
                LampLight.GetComponent<Animation>().Play("LampAnimation002");
            }
            if (ModeForLights == 3)
            {
                LampLight.GetComponent<Animation>().Play("LampAnimation003");
            }

            yield return new WaitForSeconds(0.99f);
            ModeForLights = 0;
        }
    
}

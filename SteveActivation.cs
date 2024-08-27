using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveActivation : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        SteveAI.isStalking = true;
    }
}

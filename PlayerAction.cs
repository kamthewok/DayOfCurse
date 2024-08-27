using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public static float DistanceFromPoint;
    public float ToPoint;


    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToPoint = Hit.distance;
            DistanceFromPoint = ToPoint;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_2 : MonoBehaviour
{
    public GameObject Circle;
    Collider circlecollider;
    void Start()
    {
        Circle = GameObject.Find("circle");
        circlecollider = GetComponent<Collider>();
        //Ball.AddComponent<Collider>();
        circlecollider.isTrigger = false;

    }


    void Update()
    {
        //if(OnCollisionEnter==true)
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Yo man");
    }
}

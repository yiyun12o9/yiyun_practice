using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_1 : MonoBehaviour
{
    public GameObject Ball, Ball1;
    Collider ballcollider;
    void Start()
    {
        Ball = GameObject.Find("ball");
        Ball1 = GameObject.Find("ball1");
        ballcollider = GetComponent<Collider>();
        //Ball.AddComponent<Collider>();
        ballcollider.isTrigger = false;
        
    }

    
    void Update()
    {
        //if(OnCollisionEnter==true)
    }
    void OnCollisionEnter(Collision collision) 
    {
        Debug.Log("helloworld");
    }
}

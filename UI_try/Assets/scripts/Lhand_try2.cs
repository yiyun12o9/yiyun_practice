using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Interactable))]
public class Lhand_try2 : MonoBehaviour
{
    public SteamVR_Action_Boolean GrabPinch;  //板機鍵按鈕
    public Button paint;

    protected virtual void Awake()
    {
        paint = GetComponent<Button>();
        if (paint)
        {
            paint.onClick.AddListener(Paint);
        }
    }

    void Start()
    {
        
    }

    void Paint()
    {
        Debug.Log("click button1");
    }

    void Update()
    {
        
    }
}
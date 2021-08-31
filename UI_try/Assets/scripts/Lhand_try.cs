using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class Lhand_try : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Action_Boolean GrabPinch;  //板機鍵按鈕
    public SteamVR_Behaviour_Pose Pose;
    public GameObject icon;
    public Vector3 Lhandmove;
    public Button paint;
    public bool pressed;
    private void Awake()
    {
        Pose = GetComponent<SteamVR_Behaviour_Pose>();
        
    }

    void Start()
    {
        icon.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0f, 0.1f, 0.2f);
        
        //GetComponent<icon>().onClick.AddListener(paint);
    }



    public void Paint()
    {
        Debug.Log("click button1");
        //icon.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0.5f, 0.1f, 0.2f);
        //icon.transform.position.x = 100;
    }
    public void Palette()
    {
        Debug.Log("click button2");
    }
    public void Eraser()
    {
        Debug.Log("click button3");
    }
    public void Clear()
    {
        Debug.Log("click button4");
    }
    public void Undo()
    {
        Debug.Log("click button5");
    }
    public void Redo()
    {
        Debug.Log("click button6");
    }
    

    void Update()
    {
        Lhandmove = Pose.GetVelocity();
        //Lhandmove = new Vector3(-100f, -100f, -100f);
        //Lhandmove = Pose.GetPostion() * -1;

        //icon.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0.5f, 0.3f, 0f);
        /*if (GrabPinch.GetStateDown(Pose.inputSource))
        {
            paint.onClick.AddListener(Paint);
            paint.interactable = !paint.interactable;

        }*/
        //paint.onClick.AddListener(Paint);
        /*if (paint.pressed == true)
        {

        }*/

    }


    // Update is called once per frame

}

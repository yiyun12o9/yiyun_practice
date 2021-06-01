using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Lhand_try : MonoBehaviour
{
    // Start is called before the first frame update
    private SteamVR_Behaviour_Pose Pose;
    public GameObject icon;
    private Vector3 Lhandmove;
    private void Awake()
    {
        Pose = GetComponent<SteamVR_Behaviour_Pose>();
    }
    public void paint()
    {
        Debug.Log("click button1");
    }
    public void palette()
    {
        Debug.Log("click button2");
    }
    public void eraser()
    {
        Debug.Log("click button3");
    }
    public void clear()
    {
        Debug.Log("click button4");
    }
    public void undo()
    {
        Debug.Log("click button5");
    }
    public void redo()
    {
        Debug.Log("click button6");
    }
    
    void Start()
    {

    }
    void Update()
    {
        //Lhandmove = Pose.GetVelocity();
        //Lhandmove = new Vector3(-100f, -100f, -100f);
        //Lhandmove = Pose.GetPostion() * -1;

        //icon.transform.position = Lhandmove;
    }


    // Update is called once per frame

}

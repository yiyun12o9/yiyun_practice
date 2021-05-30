using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Lhand_try : MonoBehaviour
{
    // Start is called before the first frame update
    private SteamVR_Behaviour_Pose Pose;
    public GameObject icon;
    private void Awake()
    {
        Pose = GetComponent<SteamVR_Behaviour_Pose>();
    }
    private Vector3 Lhandmove;
    void Start()
    {

    }
    void Update()
    {
        Lhandmove = Pose.GetVelocity();
        //Lhandmove = m_Pose.GetPostion();

        icon.transform.position = Lhandmove;
    }


    // Update is called once per frame

}

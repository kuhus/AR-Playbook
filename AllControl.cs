using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllControl : MonoBehaviour
{
    public Animator monitor;
    //public Animator interiorpanel;
    //public Animator keyframe;

    public void MonitorClose()
    {
        monitor.SetBool("close", true);
    }

    public void MonitorOpen()
    {
        monitor.SetBool("close", false);
    }

    /*public void InteriorPanelExpand()
    {
        interiorpanel.SetBool("expand,true");
    }

    public void KeyboardFrameExpand()
    {
        keyframe.SetBool("expand,true");
    }*/
}

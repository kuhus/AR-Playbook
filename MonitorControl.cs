using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorControl : MonoBehaviour
{
    public Animator animator;

    public void Close()
    {
        animator.SetBool("close", true);
    }

    public void Open()
    {
        animator.SetBool("close", false);
    }
}

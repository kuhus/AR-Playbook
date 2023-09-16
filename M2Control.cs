using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2Control : MonoBehaviour
{
    public Animator animator;

    public void Expand()
    {
        animator.SetBool("expand", true);
    }

    public void Hide()
    {
        animator.SetBool("expand", false);
    }

    public void StartRotate()
    {
        animator.SetBool("rotate", true);
    }

    public void StopRotate()
    {
        animator.SetBool("rotate", false);
    }
}
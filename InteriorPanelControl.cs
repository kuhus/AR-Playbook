using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorPanelControl : MonoBehaviour
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
}

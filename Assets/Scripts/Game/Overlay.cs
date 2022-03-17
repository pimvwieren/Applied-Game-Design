using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Overlay : MonoBehaviour, IPointerClickHandler
{
    private Animator animator;
    private static readonly int Show = Animator.StringToHash("show");

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // HideOverlay();
    }

    public virtual void ShowOverlay()
    {
        animator.SetBool(Show, true);
    }

    public void HideOverlay()
    {
        animator.SetBool(Show, false);
    }
}

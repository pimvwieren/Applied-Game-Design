using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverScript : MonoBehaviour
{
    public LayerMask selectableLayer;
    public Animator cameraAnimator;
    private Camera camera;
    private Animator hoverAnimator;

    private string currentlyFocusedObjectName;
    
    private void Start()
    {
        camera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, selectableLayer))
        {
            hoverAnimator = hit.transform.gameObject.GetComponent<Animator>();
            hoverAnimator.SetBool("isSelected", true);

            if (Input.GetMouseButtonUp(0))
            {
                if (hit.transform.gameObject.name == currentlyFocusedObjectName)
                {
                    Interactable ix = hit.transform.gameObject.GetComponent<Interactable>();
                    if (ix)
                    {
                        ix.OnInteract();
                    }
                }
                else
                {
                    currentlyFocusedObjectName = hit.transform.gameObject.name;
                    cameraAnimator.SetTrigger(currentlyFocusedObjectName);
                }
            }
        }
        else
        {
            if (hoverAnimator)
            {
                currentlyFocusedObjectName = "";
                hoverAnimator.SetBool("isSelected", false);
            }
        }
    }

    public void GoBack()
    {
        cameraAnimator.SetTrigger("Back");
        //ResetAllTriggers();
    }

    public void TurnLeft()
    {
        cameraAnimator.SetTrigger("Left");
        //ResetAllTriggers();
    }
    public void Turnright()
    {
        cameraAnimator.SetTrigger("Right");
        //ResetAllTriggers();
    }


    private void ResetAllTriggers()
    {
        foreach (var param in cameraAnimator.parameters)
        {
            if (param.type == AnimatorControllerParameterType.Trigger)
            {
                cameraAnimator.ResetTrigger(param.name);
            }
        }
    }
}


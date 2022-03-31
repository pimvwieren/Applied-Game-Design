using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorManager : MonoBehaviour
{
    public GameObject door;
    public GameObject[] objectsOnFighterSide;
    public GameObject[] objectsOnMageSide;

    private bool isFighterSideActive;

    private void Start()
    {
        SwitchPerspective();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Home))
        {
            SwitchPerspective();
        }
        
        if (Input.GetKeyUp(KeyCode.End))
        {
            ShowEverything();
        }
    }

    private void SwitchPerspective()
    {
        door.gameObject.SetActive(false);
        isFighterSideActive = !isFighterSideActive;
        
        foreach (GameObject g in objectsOnFighterSide)
        {
            g.gameObject.SetActive(isFighterSideActive);
        }
        
        foreach (GameObject g in objectsOnMageSide)
        {
            g.gameObject.SetActive(!isFighterSideActive);
        }
    }

    private void ShowEverything()
    {
        door.gameObject.SetActive(true);
        foreach (GameObject g in objectsOnFighterSide)
        {
            g.gameObject.SetActive(true);
        }
        
        foreach (GameObject g in objectsOnMageSide)
        {
            g.gameObject.SetActive(true);
        }

    }
}

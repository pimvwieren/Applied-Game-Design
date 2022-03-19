using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [Header("Interactable")]
    public UnityEvent OnInteractEvent;

    public virtual void OnInteract()
    {
        OnInteractEvent.Invoke();
    }
}

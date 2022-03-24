using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class CarriedItem : Interactable
{
    public enum State { LayingAround, Carried, InCauldron }
    [Header("CarriedItem")]
    public State currentState = State.LayingAround;

    public int uid;
    [HideInInspector] public Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    public void SetState(State state)
    {
        currentState = state;
    }

    private bool HasState(State state)
    {
        return currentState == state;
    }

    public override void OnInteract()
    {
        if (HasState(State.InCauldron))
        {
            PickUp(FindObjectOfType<PlayerHand>());
        }
        else if (HasState(State.Carried))
        {
            PutBack();
        }
        else
        {
            base.OnInteract();            
        }
    }

    public void OnPickedUp()
    {
        SetState(State.Carried);
    }

    public void PutBack()
    {
        transform.SetParent(null);
        transform.position = startPos;
        SetState(State.LayingAround);
    }

    public void PickUp(PlayerHand playerHand)
    {
        transform.SetParent(playerHand.transform, false);
        transform.localPosition = Vector3.zero;
        SetState(State.Carried);
    }

    public void PutInCauldron(Cauldron cauldron)
    {
        CauldronItemSlot slot = cauldron.itemSlots.First(s => s.ingredient == null);
        
        transform.SetParent(slot.transform, false);
        SetState(State.InCauldron);
        
        slot.AssignTo(this);
        FindObjectOfType<PlayerHand>().Clear();
    }
}

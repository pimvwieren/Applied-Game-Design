using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : Interactable
{
    [Range(1, 3)] public int fallaciesToSolve = 3;
    private int remainingFallacyCount;

    public enum State { Sentient, Dormant, InCauldron }
    public State currentState = State.Sentient;

    public override void OnInteract()
    {
        switch (currentState)
        {
            case State.Sentient:
                base.OnInteract();
                break;
            case State.Dormant:
                FindObjectOfType<PlayerHand>().CloneAndCarryItem(gameObject);
                break;
            case State.InCauldron:
                FindObjectOfType<Cauldron>().RemoveIngredient(this);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void SolveFallacy()
    {
        remainingFallacyCount--;
        if (remainingFallacyCount == 0)
        {
            currentState = State.Dormant;
        }
    }
}

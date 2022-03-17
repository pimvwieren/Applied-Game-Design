using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Interactable
{
    [Range(1, 3)] public int fallaciesToSolve = 3;
    private int remainingFallacyCount;

    private enum State { Sentient, Dormant }
    private State currentState = State.Sentient;

    public override void OnInteract()
    {
        if (currentState == State.Sentient)
        {
            base.OnInteract();
        }
        else
        {
            // komt nog
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

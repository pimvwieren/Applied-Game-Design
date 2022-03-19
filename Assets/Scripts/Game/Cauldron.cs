using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Cauldron : Interactable
{
    [HideInInspector] public CauldronItemSlot[] itemSlots;

    private void Awake()
    {
        itemSlots = GetComponentsInChildren<CauldronItemSlot>();
    }

    public void AddHeldIngredient()
    {
        PlayerHand playerHand = FindObjectOfType<PlayerHand>();
        CarriedItem carriedItem = playerHand.currentlyHeldItem;
        
        if (!carriedItem) return;

        carriedItem.PutInCauldron(this);
    }

    public void RemoveIngredient(Ingredient ingredient)
    {
        CauldronItemSlot cauldronItemSlot = itemSlots.First(slot => slot.ingredient.GetType() == ingredient.GetType());
        cauldronItemSlot.Clear();
    }
}
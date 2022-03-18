using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Cauldron : Interactable
{
    private CauldronItemSlot[] itemSlots;

    private void Awake()
    {
        itemSlots = GetComponentsInChildren<CauldronItemSlot>();
    }

    public void AddHeldIngredient()
    {
        GameObject carriedItem = FindObjectOfType<PlayerHand>().carriedItem;
        if (!carriedItem) return;
        Ingredient ingredient = carriedItem.GetComponent<Ingredient>();
        if (!ingredient) return;

        CauldronItemSlot cauldronItemSlot = itemSlots.First(slot => slot.ingredient == null);
        cauldronItemSlot.AssignTo(ingredient);
    }

    public void AddIngredient(Ingredient ingredient)
    {
        CauldronItemSlot cauldronItemSlot = itemSlots.First(slot => slot.ingredient == null);
        cauldronItemSlot.AssignTo(ingredient);
    }

    public void RemoveIngredient(Ingredient ingredient)
    {
        CauldronItemSlot cauldronItemSlot = itemSlots.First(slot => slot.ingredient.GetType() == ingredient.GetType());
        cauldronItemSlot.Clear();
    }
}
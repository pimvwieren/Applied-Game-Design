using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public RegisteredItem[] registeredItems;
    public CarriedItem currentlyHeldItem;

    public void CloneAndCarryItem(int ingredientId)
    {
        if (currentlyHeldItem)
        {
            currentlyHeldItem.PutBack();
        }
        
        CarriedItem item = FindObjectsOfType<CarriedItem>().First(i => i.uid == ingredientId);

        if (item)
        {
            currentlyHeldItem = item;
            item.PickUp(this);
        }
        else
        {
            Debug.LogWarning("No registered item found with id [" + ingredientId + "]");
        }
    }

    public void Clear()
    {
        currentlyHeldItem = null;
    }
}

[Serializable]
public class RegisteredItem
{
    public int id;
    public CarriedItem prefab;
}
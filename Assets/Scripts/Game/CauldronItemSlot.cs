using UnityEditor;
using UnityEngine;

public class CauldronItemSlot : MonoBehaviour
{
    public CarriedItem ingredient;

    public void AssignTo(CarriedItem item)
    {
        ingredient = item;
    }

    public void Clear()
    {
        Destroy(GetComponentInChildren<Ingredient>().gameObject);
        ingredient = null;
    }
}
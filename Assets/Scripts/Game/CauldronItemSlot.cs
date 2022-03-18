using UnityEngine;

public class CauldronItemSlot : MonoBehaviour
{
    public Ingredient ingredient;

    public void AssignTo(Ingredient newIngredient)
    {
        ingredient = newIngredient;
        ingredient.transform.SetParent(transform);
        ingredient.currentState = Ingredient.State.InCauldron;
    }

    public void Clear()
    {
        Destroy(GetComponentInChildren<Ingredient>().gameObject);
        ingredient = null;
    }
}
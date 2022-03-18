using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public GameObject carriedItem;

    public void CloneAndCarryItem(GameObject obj)
    {
        if (carriedItem)
        {
            Destroy(carriedItem.gameObject);
        }
        
        carriedItem = Instantiate(obj, transform.position, Quaternion.identity);
        carriedItem.transform.SetParent(transform);
    }
}

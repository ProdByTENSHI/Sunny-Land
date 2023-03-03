using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItemManager : MonoBehaviour
{
    private Dictionary<string, PointItem> items;

    private void Start()
    {
        PointItem.onCollect += Remove;

        items = new Dictionary<string, PointItem>();
        foreach(PointItem item in FindObjectsOfType<PointItem>())
        {
            // Only Add Item to Dictionary if the List doesn't already Contain the Item
            if(!items.ContainsKey(item.GetID()))
                items.Add(item.GetID(), item);
        }
    }

    // Remove Item from Dictionary with Item ID
    private void Remove(string id)
    {
        items.Remove(id);
    }
}
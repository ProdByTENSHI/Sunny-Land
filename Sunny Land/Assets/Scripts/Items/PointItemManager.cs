using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItemManager : MonoBehaviour
{
    private Dictionary<string, PointItem> items;

    private void Start()
    {
        PointItem.onCollect += RemovePointItem;

        items = new Dictionary<string, PointItem>();
        foreach(PointItem item in FindObjectsOfType<PointItem>())
        {
            items.Add(item.GetID(), item);
            Debug.Log("Added Item: " + item.name);
        }
    }

    private void RemovePointItem(string id)
    {
        items.Remove(id);
    }
}
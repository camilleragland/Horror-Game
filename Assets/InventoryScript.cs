using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript: MonoBehaviour

{
    #region Singleton
    public static InventoryScript instance;
   void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return; 
        }

        instance = this; 
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback; 

    public int space = 9; 

    public List<InventoryItem> items = new List<InventoryItem>();

    public bool Add(InventoryItem item)
    {
        if (!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Not enough room!");
                return false; 
            }

            items.Add(item);
        }
        return true; 
    }

    public void Remove (InventoryItem item)
    {
        items.Remove(item);
    }
}

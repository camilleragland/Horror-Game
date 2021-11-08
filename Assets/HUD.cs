using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    InventoryScript Inventory;

     void Start()
    {
        Inventory = InventoryScript.instance;
        Inventory.onItemChangedCallback += UpdateUI;

    }

     void Update()
    {
        
    }

    void UpdateUI()
    {
        Debug.Log("Updating UI");
    }
}

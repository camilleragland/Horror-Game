
using UnityEngine;

public class ItemPickup : Interactable
{

    public InventoryItem item; 
    public override void Interact()
    {
        base.Interact();

        PickUp(); 
    }

    void PickUp()
    {
        
        Debug.Log("Picking up" + item.name);

        //Add to inventory

        bool wasPickedUp = InventoryScript.instance.Add(item); 

        //destorys item
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
        
    }
}


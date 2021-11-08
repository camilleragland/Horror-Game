using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform; 

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false; 

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }
    void Update()
    {
        if(isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if(distance <= radius)
            {
                Interact();
                hasInteracted = true; 
            }
        }
    }
    public void onFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = true; 
    }

    public void onDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false; 
    }

    void onDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform; 
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}

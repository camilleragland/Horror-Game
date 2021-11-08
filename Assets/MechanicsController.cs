using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechanicsController : MonoBehaviour
{
    Camera cam;
    public Interactable focus;

    void Start()
    {
        cam = Camera.main;
    }

     void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit, 100))
            {
                //check if we hit interactable 
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }

    }

    void SetFocus(Interactable newFocus)
    {
        if(newFocus != focus)
        {   
            if(focus != null)
            focus.onDefocused();
            focus = newFocus;
        }

        focus = newFocus;
        newFocus.onFocused(transform);
    }
}

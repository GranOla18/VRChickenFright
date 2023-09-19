using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Is in layer 6 = Interactable
        if (other.GetComponent<LayerMask>() == 6)
        {
            Interact();
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interact");
    }
}

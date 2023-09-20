using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    //public float radius;
    //public Transform player;
    public bool canInteract;

    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(transform.position, radius);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerManager>())
        {
            Debug.Log("Can Interact");
            canInteract = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerManager>())
        {
            Debug.Log("Can NOT Interact");
            canInteract = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            if (canInteract)
            {
                Interact();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
            {
                Interact();
            }
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interact Base");
    }
}

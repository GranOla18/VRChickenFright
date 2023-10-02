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
        // The player can only interact with objects in layer 6
        if (other.GetComponent<PlayerManager>())
        {
            if(this.gameObject.layer == 6)
            {
                Debug.Log("Can Interact");
                canInteract = true;
            }
        }

        // If other object is damageable
        if (other.GetComponent<PlayerManager>() || other.gameObject.layer == 7)
        {
            Hit(other);
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
        //if (Input.GetKeyDown(KeyCode.Joystick2Button0))
        if (Input.GetKeyDown(KeyCode.Joystick2Button0))
        {
            if (canInteract)
            {
                Interact();
            }
        }

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    if (canInteract)
        //    {
        //        Interact();
        //    }
        //}
    }

    public virtual void Interact()
    {
        Debug.Log("Interact Base");
    }

    public virtual void Hit(Collider other)
    {
        Debug.Log("Hit Base");
    }
}

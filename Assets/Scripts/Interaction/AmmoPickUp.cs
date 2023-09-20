using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : Interactable
{
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Ammo");
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}

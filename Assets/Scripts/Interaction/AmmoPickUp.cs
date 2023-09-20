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
        GameManager.instance.bullets += 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : Interactable
{
    [SerializeField] private int ammoAmount;
    //[ContextMenu("Cola")]
    public override void Interact()
    {
        SFXController.instance.ReproduceSFX(3);
        base.Interact();
        Debug.Log("Ammo");
        //Destroy(this.gameObject);
        this.gameObject.SetActive(false);
        GameManager.instance.bullets += ammoAmount;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}

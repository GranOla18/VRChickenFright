using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : Interactable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Hit(Collider otherObj)
    {
        otherObj.GetComponent<IDamage>().Damage();
        Debug.Log("Hit a: " + otherObj.name);
    }

}

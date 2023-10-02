using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    [SerializeField] GunShoot gunShoot;
    [SerializeField] FlashlightBehavior flashlight;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.enabled = true;
        gunShoot.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrabFlashlight()
    {
        flashlight.enabled = !flashlight.enabled;
    }

    public void GrabGun()
    {
        gunShoot.enabled = true;
    }

    public void DropGun()
    {
        gunShoot.enabled = false;
    }

    public void GrabKey()
    {
        SFXController.instance.ReproduceSFX(4);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySFX : MonoBehaviour
{
    public void PickUpSFX()
    {
        SFXController.instance.ReproduceSFX(4);
    }

    public void UseSFX()
    {
        SFXController.instance.ReproduceSFX(5);
    }
}

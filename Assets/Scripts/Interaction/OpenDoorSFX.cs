using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSFX : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerManager>() || collision.gameObject.GetComponent<GrabObject>())
        {
            Debug.Log("Collision enter");
            SFXController.instance.ReproduceSFX(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SFXController.instance.ReproduceSFX(2);
    }
}

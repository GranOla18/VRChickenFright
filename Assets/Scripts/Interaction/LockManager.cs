using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class LockManager : MonoBehaviour
{
    XRSocketInteractor socket;
    public GameObject barrier;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void UnlockDoor()
    {

        IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

        Debug.Log(objName.transform.name + " in socket of " + transform.name);
        GameObject objNameCol = objName.transform.gameObject;
        if (objNameCol.tag == "Key" )
        {
            SFXController.instance.ReproduceSFX(5);
            Destroy(barrier);
            Destroy(objNameCol);

        }

    }

}

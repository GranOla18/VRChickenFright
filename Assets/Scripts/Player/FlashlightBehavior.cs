 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehavior : MonoBehaviour
{
    [SerializeField] private Light flLightOut;
    [SerializeField] private Light flLightMid;
    [SerializeField] private Light flLightInner;

    // Update is called once per frame
    void Update()
    {
        // PC Testing
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    flLight.enabled = !flLight.enabled;
        //}

        // Button Y
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            flLightOut.enabled = !flLightOut.enabled;
            flLightMid.enabled = !flLightMid.enabled;
            flLightInner.enabled = !flLightInner.enabled;
        }
    }
}

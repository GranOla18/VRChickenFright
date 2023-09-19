 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightBehavior : MonoBehaviour
{
    private Light flLight;

    // Start is called before the first frame update
    void Start()
    {
        flLight = GetComponent<Light>();
    }

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
            flLight.enabled = !flLight.enabled;
        }
    }
}

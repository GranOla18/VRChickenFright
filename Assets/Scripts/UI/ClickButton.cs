using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    RaycastHit choque;
    Ray rayo;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        rayo.origin = transform.position + offset;
        rayo.direction = transform.forward;

        Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.green);

        if (Input.GetKeyDown(KeyCode.Joystick2Button0))
        {
            if (Physics.Raycast(rayo, out choque))
            {

                if (choque.collider)
                {
                    Button button = choque.collider.GetComponent<Button>();
                    {
                        if (button)
                        {
                            button.onClick.Invoke();
                        }
                    }
                }

            }
        }
    }
}

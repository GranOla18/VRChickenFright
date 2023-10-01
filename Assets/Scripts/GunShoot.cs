using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(LineRenderer))]
public class GunShoot : MonoBehaviour
{
    private RaycastHit choque;
    private Ray rayo;
    public Vector3 offset;

    [SerializeField] private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        rayo.origin = transform.position + offset;
        rayo.direction = transform.forward;
        lineRenderer.SetPosition(0, transform.position);

        Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.blue);

        if (Input.GetKeyDown(KeyCode.Joystick2Button15))
        {
            if (Physics.Raycast(rayo, out choque))
            {
                Debug.Log(choque.collider.name);

                if (choque.collider.gameObject.layer == 7)
                {
                    choque.collider.gameObject.GetComponent<IDamage>().Damage();
                }

            }
        }

        else if (Input.GetKeyDown(KeyCode.Joystick2Button5))
        {
            lineRenderer.SetPosition(1, transform.forward * 20);
            lineRenderer.startWidth = 0.05f;
            lineRenderer.endWidth = 0.05f;
        }

        else if (Input.GetKeyDown(KeyCode.Joystick2Button5))
        {
            lineRenderer.startWidth = 0f;
            lineRenderer.endWidth = 0f;
        }
    }
}
    
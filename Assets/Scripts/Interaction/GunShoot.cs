using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(LineRenderer))]
public class GunShoot : MonoBehaviour
{
    private RaycastHit choque;
    private Ray rayo;
    public Transform laserForward;
    public Vector3 laserEnd;

    [SerializeField] private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        laserEnd = transform.forward * 20;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0f;
        lineRenderer.endWidth = 0f;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, laserEnd);
    }

    private void Update()
    {
        rayo.origin = transform.position;
        rayo.direction = transform.forward;
        lineRenderer.SetPosition(0, transform.position);
        laserEnd = transform.forward * 20;

        Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.blue);

        if (Input.GetKeyDown(KeyCode.Joystick2Button15) && GameManager.instance.bullets > 0)
        //if (Input.GetKeyDown(KeyCode.E) && GameManager.instance.bullets > 0)
        {
            GameManager.instance.Shoot();
            if (Physics.Raycast(rayo, out choque))
            {
                Debug.Log(choque.collider.name);

                if (choque.collider.gameObject.layer == 7)
                {
                    choque.collider.gameObject.GetComponent<IDamage>().Damage();
                }

            }
        }

        else if (Input.GetKeyDown(KeyCode.Joystick2Button1))
        {
            lineRenderer.SetPosition(1, laserForward.position);
            lineRenderer.startWidth = 0.05f;
            lineRenderer.endWidth = 0.05f;
        }

        //else if (Input.GetKeyUp(KeyCode.Joystick2Button1))
        else if (Input.GetKeyUp(KeyCode.Joystick2Button1))
        {
            lineRenderer.startWidth = 0f;
            lineRenderer.endWidth = 0f;
        }


    }
}
    
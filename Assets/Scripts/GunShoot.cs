using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    RaycastHit choque;
    Ray rayo;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        rayo.origin = transform.position + new Vector3(0, 1, 0);
        rayo.direction = transform.forward;

        Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.blue);

        if (choque.collider.gameObject.layer == 7)
        {
            choque.collider.gameObject.GetComponent<IDamage>().Damage();
        }
    }
}
    
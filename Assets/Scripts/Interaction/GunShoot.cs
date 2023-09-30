using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    RaycastHit choque;
    Ray rayo;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    //private void Update()
    //{

    //}

    // Update is called once per frame
    private void FixedUpdate()
    {

        rayo.origin = transform.position + offset;
        rayo.direction = transform.forward;

        Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.blue);

        if (Physics.Raycast(rayo, out choque))
        {
            Debug.Log(choque.collider.name);

            if (choque.collider.gameObject.layer == 7)
            {
                choque.collider.gameObject.GetComponent<IDamage>().Damage();
            }

        }



        //if (choque.collider.gameObject.layer == 7)
        //{
        //    choque.collider.gameObject.GetComponent<IDamage>().Damage();
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelEnd;

    private ProjectileDestruction myDestruction;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectileInstance;
            //Instantiate(projectile);
            //Instantiate(projectile, barrelEnd.position, barrelEnd.rotation);
            projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            //projectileInstance.AddForce(barrelEnd.up * 350f);
            projectileInstance.AddForce(new Vector3(0,0,1) * 350f);

            // active destruction instantiate object
            myDestruction = projectileInstance.GetComponent<ProjectileDestruction>();
            myDestruction.enabled = true;
        }
    }
}

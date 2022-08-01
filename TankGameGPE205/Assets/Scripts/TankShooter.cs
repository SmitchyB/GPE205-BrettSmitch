using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : Shooter
{
    public Transform FireTransform; // A child of the tank where the shells are spawned.

    // Start is called before the first frame update
    public override void Start()
    {
  
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

    public override void Shoot(GameObject Shell, float fireForce, float DamageDone, float Lifespan)
    {
        Debug.Log("Fired");
        GameObject newShell = Instantiate(Shell, FireTransform.position, FireTransform.rotation) as GameObject;
        DamageOnHit doh = newShell.GetComponent<DamageOnHit>();

        if (doh != null)
        {
            doh.DamageDone = DamageDone;
            doh.owner = GetComponent<Pawn>();
        }

        Rigidbody rb = newShell.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(FireTransform.forward * fireForce);
        }
        Destroy(newShell, Lifespan);
        
    }
}

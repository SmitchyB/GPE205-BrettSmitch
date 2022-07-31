using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : Shooter
{
    
    // public Rigidbody Shell;  // Prefab of the shell.
    public Transform FireTransform; // A child of the tank where the shells are spawned.
    // public float MinLaunchForce = 15f;   // The force given to the shell if the fire button is not held.
    // public float MaxLaunchForce = 30f;   // The force given to the shell if the fire button is held for the max charge time.
    // public float MaxChargeTime = 0.75f;  // How long the shell can charge for before it is fired at max force.
    // private float CurrentForce; 
    // private float ChargeSpeed; 
    // private bool Fired;

    //public PlayerController controller;

    // Start is called before the first frame update
    public override void Start()
    {
        //calculates the charge speed using speed/time
        // ChargeSpeed = (MaxLaunchForce - MinLaunchForce) / MaxChargeTime;
    }

    // Update is called once per frame
    public override void Update()
    {
        // max charge but not fired yet
        // if(CurrentForce >= MaxLaunchForce && !Fired)
        // {

        // }
        // //checking if the fire button has been pressed
        // else if(Input.GetKey(controller.FireButton))
        // {
        
        // }
        // //Checking if the fire button is being held and not yet fired
        // else if(Input.GetKeyDown(controller.FireButton))
        // {

        // }
        // //checking if the fire button was released
        // else if(Input.GetKeyUp(controller.FireButton))
        // {

        // }
    }

    public override void Shoot(GameObject Shell, float fireForce, float DamageDone, float Lifespan)
    {
        Debug.Log("Fire");
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

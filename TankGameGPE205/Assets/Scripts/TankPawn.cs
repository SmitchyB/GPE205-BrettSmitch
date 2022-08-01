using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{
    private bool ReadyToFire;
    private float timeUntilNextEvent = 0;
    //override of the start function in the pawn class
    public override void Start()
    {
        //this is geting the start function from the base class(parent class)
        base.Start();
        ReadyToFire = true;
    }
    //override of the update funcion in the pawn class
    public override void Update()
    {
        //this is geting the update function from the base class(parent class)
        base.Update();
        timeUntilNextEvent -= Time.deltaTime;
        if(timeUntilNextEvent <= 0)
        {
            ReadyToFire = true;
        }
        if(ReadyToFire == true && Input.GetKey(controller.FireButton))
        {
            Fire(); 
            ReadyToFire = false;
            timeUntilNextEvent += fireRate;
        }
        else if (ReadyToFire == false)
        {
            Debug.Log("It aint time. Wait for: " + timeUntilNextEvent + " Seconds");
        }
    }
    //override of the MoveForward function initiated in the Pawn class
    public override void MoveForward()
    {
        //runs the move function from mover/tankmover and applies the MoveSpeed
        mover.MoveForward(transform.forward, MoveSpeed);
    }
    //override of the MoveBackwards function initiated in the Pawn Class
    public override void MoveBackward()
    {
        //runs the move function from mover/tankmover and applies the MoveSpeed
        mover.MoveBackward(transform.forward * -1, MoveSpeed);
    }
    //override of the RotateClockwise function initiated in the Pawn Class
    public override void RotateClockwise()
    {
        //runs the move function from mover/tankmover and applies the Turnspeed 
        mover.ClockwiseRotation(TurnSpeed);
    }
    //override of the RotateCounter function initiated in the Pawn class
    public override void RotateCounter()
    {
        //runs the move function from mover/tankmover and applies the Turnspeed 
        mover.CounterClockwiseRotation(TurnSpeed);
        
    }

    public override void Fire()
    {
        shooter.Shoot(Shell, fireForce, DamageDone, Lifespan);      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{

    //override of the start function in the pawn class
    public override void Start()
    {
        //this is geting the start function from the base class(parent class)
        base.Start();
    }
    //override of the update funcion in the pawn class
    public override void Update()
    {
        //this is geting the update function from the base class(parent class)
        base.Update();
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
}

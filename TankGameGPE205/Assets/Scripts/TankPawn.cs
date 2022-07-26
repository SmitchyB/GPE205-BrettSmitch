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
        Debug.Log("Forward");
        mover.MoveForward(transform.forward, MoveSpeed);
    }
    //override of the MoveBackwards function initiated in the Pawn Class
    public override void MoveBackward()
    {
        Debug.Log("Back");
        mover.MoveBackward(transform.forward * -1, MoveSpeed);
    }
    //override of the ClockwiseRotation function initiated in the Pawn Class
    public override void RotateClockwise()
    {
        Debug.Log("Clockwise");
        mover.ClockwiseRotation(TurnSpeed);
    }
    //override of the CounerclockwiseRotation function initiated in the Pawn class
    public override void RotateCounter()
    {
        Debug.Log("CounterClockwise");
        mover.CounterClockwiseRotation(TurnSpeed);
        
    }
}

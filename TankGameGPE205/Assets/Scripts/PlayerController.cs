using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    //keycodes for our movement
    public KeyCode MoveForwardKey;
    public KeyCode MoveBackwardKey;
    public KeyCode ClockwiseRotationKey;
    public KeyCode CounterClockwiseKey;
    public KeyCode FireButton;

    //overrride of the start function to run the base class start function
    public override void Start()
    {
        base.Start();
    }
    //override update that will be called once per frame and wil process keyboard inputs and run the update function from the base class.
    public override void Update()
    {
        //process the keyboard inputs
        ProcessInputs();
        base.Update();
    }
    //public override void PorcessInputs
    public void ProcessInputs()
    {
        if (Input.GetKey(MoveForwardKey)) 
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(MoveBackwardKey)) 
        {
            pawn.MoveBackward();
        }

        if (Input.GetKey(ClockwiseRotationKey)) 
        {
            pawn.RotateClockwise();
        }

        if (Input.GetKey(CounterClockwiseKey)) 
        {
            pawn.RotateCounter();
        }
    }
}

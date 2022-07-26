using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : Mover
{
    // Variable to hold the Rigidbody Component
    private Rigidbody MainRigidBody;
    private Transform MainTransform;


    //overrides the start function in the mover class and gets the rigidbody componant
    public override void Start()
    {
        //gets the rigidbody from the tank
        MainRigidBody = GetComponent<Rigidbody>();    
    }
    //overrides the forard movement class
    public override void MoveForward(Vector3 direction, float MoveSpeed)
    {
        //applies time and movespeed to a forward movement based on the tanks position not world space
        Vector3 TankMovement = direction.normalized;
        MainRigidBody.MovePosition(MainRigidBody.position + TankMovement * Time.deltaTime * MoveSpeed);
        
    }
    //overrides the backwards movement class
    public override void MoveBackward(Vector3 direction, float MoveSpeed)
    {
        //applies time and movespeed to a backward movement based on the tanks position not world space
        Vector3 TankMovement = direction.normalized;
        MainRigidBody.MovePosition(MainRigidBody.position + TankMovement * Time.deltaTime * MoveSpeed);
    }
    //overrides the clockwise rotation and applies the turnspeed and time based on the the local coordinate
    public override void ClockwiseRotation(float TurnSpeed)
    {
        //rotates the tank based on its local coordinate and applies the turnspeed and time to its Yaxis
        this.gameObject.transform.Rotate(0, TurnSpeed, 0 * Time.deltaTime, Space.Self);
    }
    //overrides the counter clockwise rotation and applies the turnspeed and time based on the the local coordinate
    public override void CounterClockwiseRotation(float TurnSpeed)
    {
        //rotates the tank counter clockwise based on its local coordinate and applies the turnspeed *-1(to turn counter clockwise) and time to its Yaxis
        this.gameObject.transform.Rotate(0, TurnSpeed * -1, 0 * Time.deltaTime, Space.Self);
    }
   
}

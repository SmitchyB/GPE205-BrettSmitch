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
        MainRigidBody = GetComponent<Rigidbody>();    
    }

    public override void MoveForward(Vector3 direction, float MoveSpeed)
    {
        Vector3 TankMovement = direction.normalized;
        MainRigidBody.MovePosition(MainRigidBody.position + TankMovement * Time.deltaTime * MoveSpeed);
        
    }

    public override void MoveBackward(Vector3 direction, float MoveSpeed)
    {
        Vector3 TankMovement = direction.normalized;
        MainRigidBody.MovePosition(MainRigidBody.position + TankMovement * Time.deltaTime * MoveSpeed);
    }

    public override void ClockwiseRotation(float TurnSpeed)
    {
        this.gameObject.transform.Rotate(0, TurnSpeed, 0 * Time.deltaTime, Space.Self);
    }

    public override void CounterClockwiseRotation(float TurnSpeed)
    {
        this.gameObject.transform.Rotate(0, TurnSpeed * -1, 0 * Time.deltaTime, Space.Self);
    }
   
}

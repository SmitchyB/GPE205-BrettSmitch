using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    // Start is called before the first frame update made abstract to change in each of the children
    public abstract void Start();
    //the move forward class that will be adjusted in each of the children
    public abstract void MoveForward(Vector3 direction, float Speed);

    public abstract void MoveBackward(Vector3 direction, float Speed);

    public abstract void ClockwiseRotation(float TurnSpeed);
  
    public abstract void CounterClockwiseRotation(float TurnSpeed);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
  //functions for moving forward, back and rotating.
  public abstract void MoveForward();
  public abstract void MoveBackward();
  public abstract void RotateClockwise();
  public abstract void RotateCounter();

  //floats for move and turn speed
  public float MoveSpeed;
  public float TurnSpeed;
  
  //holds the mover class
  public Mover mover;

    //Start and updating functions tha might be overriden in the child classes.
  public virtual void Start()
  {
    //calls the mover class
     mover = GetComponent<Mover>();
  }

  public virtual void Update()
  {

  }

}

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
  public abstract void Fire();

  //floats for move and turn speed
  public float MoveSpeed;
  public float TurnSpeed;


    // Variable for our shell prefab
    public GameObject Shell;
    // Variable for our firing force
    public float fireForce;
    // Variable for our damage done
    public float DamageDone;
    // Variable for how long our bullets survive if they don't collide
    public float Lifespan;
  
  //holds the mover class
  public Mover mover;
  public Shooter shooter;

    //Start and updating functions tha might be overriden in the child classes.
  public virtual void Start()
  {
    //calls the mover class
     mover = GetComponent<Mover>();
     shooter = GetComponent<Shooter>();
  }

  public virtual void Update()
  {

  }

}

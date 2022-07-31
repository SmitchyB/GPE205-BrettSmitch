using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shooter : MonoBehaviour
{
   public abstract void Start();
   public abstract void Update();
   public abstract void Shoot(GameObject Shell, float fireForce, float DamageDone, float Lifespan);
   
}

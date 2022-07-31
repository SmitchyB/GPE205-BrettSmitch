using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float DamageDone;
    public Pawn owner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) 
    {
        //Gets health from the object
        Health otherHealth = other.gameObject.GetComponent<Health>();

        if (otherHealth != null)
        {
            //Does the Damage
            otherHealth.TakeDamage(DamageDone, owner);
        }
        //Destroys Bullet whether we did damge or not
        Destroy(gameObject);
    }
   
}

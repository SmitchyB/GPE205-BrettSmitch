using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float CurrentHealth;
    public float MaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;  
        CurrentHealth = Mathf.Clamp (CurrentHealth, 0, MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (float DamageAmount, Pawn source)
    {
        CurrentHealth = CurrentHealth - DamageAmount;
        Debug.Log(source.name + " did " + DamageAmount);

        if (CurrentHealth <= 0)
        {
            Death (source);
        }
    }

    public void Heal(float HealAmount, Pawn source)
    {
        CurrentHealth = CurrentHealth + HealAmount;
        Debug.Log(source.name + " healed " + HealAmount);

        if (CurrentHealth >= 100)
        {
            Debug.Log(source.name + "IS MAX HEALTH");
        }
    }

    public void Death(Pawn source)
    {
        Destroy(gameObject);
    }
    
}

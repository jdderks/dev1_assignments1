using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ActorBase, IDamageable
{
    private float hitpoints = 100;
    private float movementSpeed = 1;
    private float attackDamage = 5;

    public void TakeDamage(float amount)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

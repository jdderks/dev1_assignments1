using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperEnemy : ActorBase, IDamageable
{
    private float hitpoints = 1000;
    private float movementSpeed = 2;
    private float attackDamage = 10;

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

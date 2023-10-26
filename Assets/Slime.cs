using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{ 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetDamage(1);
        }
    }
    protected override void CounterAttack()
    {
        Debug.Log("El Slime a contratacado");
    }
}

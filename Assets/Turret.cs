using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : Enemy
{ 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            GetDamage(2);
        }
    }

    protected override void GetDamage(int _damage)
    {
        Debug.Log("torreta recibineendo daño");
        base.GetDamage(_damage);
    }
    protected override void CounterAttack()
    {
        Debug.Log("La torreta está contratacando");
    }
}

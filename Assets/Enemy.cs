using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int vidaEnemy;


    protected virtual void GetDamage(int _damage)
    {
        vidaEnemy -= _damage;
        CounterAttack();
        if(vidaEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }
    protected abstract void CounterAttack();
}

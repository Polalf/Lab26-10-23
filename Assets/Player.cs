using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int vidaBase = 8;
    private int vida;
    public static System.Action<int> onHealthChange;
    public static System.Action onPlayerDeath;
    public Ui uiPlayer;

    void Start()
    {
        vida= vidaBase;
        CheckDeath();
    }
    public void GetDamage(int _damage)
    {
        vida -= _damage;
        onHealthChange?.Invoke(vida);
        CheckDeath();
    }
    private void CheckDeath()
    {
        if(vida <= 0) 
        {
            onPlayerDeath();
            Destroy(gameObject);
        }
    }
  
}

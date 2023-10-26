using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executer : MonoBehaviour
{
    [SerializeField] Player player;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))player.GetDamage(1);
    }
}

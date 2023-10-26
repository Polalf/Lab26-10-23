using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui : MonoBehaviour
{
    [SerializeField] TMP_Text textVida;

    private void OnEnable()
    {
        //onPlayerDeath
        Player.onHealthChange += ShowHealth;
    }
    private void OnDisable()
    {
        Player.onHealthChange -= ShowHealth;
    }


    public void ShowHealth(int _vida)
    {
        textVida.text = "Vida : "+_vida.ToString();
    }
}

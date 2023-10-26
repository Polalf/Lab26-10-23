using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private void OnEnable()
    {
        Player.onPlayerDeath += HandlePlayerDeath;
    }
    private void OnDisable()
    {
        Player.onPlayerDeath -= HandlePlayerDeath;
    }
    public void HandlePlayerDeath()
    {
        Invoke("ResetScene",2);
    }

    private void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverUI;
    public void Restart()
    {
        PlayerCollision.isDead = false;
        Score.sIncrement = 0;
        SceneManager.LoadScene("MainScene"); 
    }

    public void MainMenu()
    {
        PlayerCollision.isDead = false;
        SceneManager.LoadScene("");
    }


    public void StartGame()
    {
        PlayerCollision.isDead = false;
        Score.sIncrement = 0;
        SceneManager.LoadScene("");
    }

   
}

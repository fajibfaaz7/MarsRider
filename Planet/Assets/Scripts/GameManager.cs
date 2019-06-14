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
        SceneManager.LoadScene("MainScene"); 
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("");
    }

    
}

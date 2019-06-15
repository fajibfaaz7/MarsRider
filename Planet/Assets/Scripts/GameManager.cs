using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public GameObject pausedUI;
    public GameObject pauseUI;
    public GameObject gameOverUI;
    public Text highScoreUI;
    public static bool isScoreStopped= false;

    void Start()
    {
        pausedUI.SetActive(false);
        pauseUI.SetActive(true);
        gameOverUI.SetActive(false);
        highScoreUI.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Update()
    {
        if (PlayerCollision.isDead == true)
        {
            gameOverUI.SetActive(true);
            pauseUI.SetActive(false);
            highScoreUI.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }

    public void Restart()
    {
        PlayerCollision.isDead = false;
        Score.sIncrement = 0;
        SceneManager.LoadScene("MainScene"); 
    }

    public void MainMenu()
    {
        PlayerCollision.isDead = false;
        Score.sIncrement = 0;
        SceneManager.LoadScene("MenuScene");
    }


    public void StartGame()
    {
        PlayerCollision.isDead = false;
        Score.sIncrement = 0;
        SceneManager.LoadScene("MainScene");
    }

    public void Revive()
    {
        PlayerCollision.isDead = false;
        SceneManager.LoadScene("MainScene");
    }

    public void Pause()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 0;
        pausedUI.SetActive(true);
        isScoreStopped = true;
    }

    public void Resume()
    {
        pausedUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 1;
        isScoreStopped = false;

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

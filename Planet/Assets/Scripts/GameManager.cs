using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private int fps = 30;
    public static GameManager instance;

    
    private void Awake()
    {
        Application.targetFrameRate = fps;
        instance = this;
    }
    public void Restart()
    { 
        PlayerCollision.isDead = false;
        Score.sIncrement = 0;
        SceneManager.LoadScene("MainScene"); 
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        GamePause.isScoreStopped = false;
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

    public void QuitGame()
    {
        Application.Quit();
    }
}

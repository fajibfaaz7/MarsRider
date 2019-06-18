using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    
    private void Awake()
    {
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

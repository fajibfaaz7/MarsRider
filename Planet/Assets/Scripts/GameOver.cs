using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text highScoreUI;
    public GameObject reviveButton;
    public static int count;

    void Start()
    {
        highScoreUI.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        gameOverUI.SetActive(false);
        
    }

    
    void Update()
    {
        if (PlayerCollision.isDead == true)
        {
            gameOverUI.SetActive(true);
            highScoreUI.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
        if (count == 1)
        {
            reviveButton.SetActive(false);
        }
        if (count == 0)
        {
            reviveButton.SetActive(true);
        }
        
    }


    public void OnceMore()
    {
        count = 1;
        GameManager.instance.Revive();

    }

    public void NoMore()
    {
        count = 0;
        GameManager.instance.Restart();
    }

    public void MainMenu()
    {
        count = 0;
        GameManager.instance.MainMenu();
    }
}

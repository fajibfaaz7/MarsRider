using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text highScoreUI;

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
    }
}

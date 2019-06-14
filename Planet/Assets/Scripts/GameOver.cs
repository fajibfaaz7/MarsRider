using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text highScoreUI;

    public void Start()
    {
        gameOverUI.SetActive(false);
        highScoreUI.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    public void Update()
    {
        if (PlayerCollision.isDead == true)
        {
            gameOverUI.SetActive(true);
            highScoreUI.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }

}

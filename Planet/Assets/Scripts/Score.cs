using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int sIncrement = 0;
    public Text scoreText;
    public Text highScoreText;

    void Update()
    {
        if(PlayerCollision.isDead == false)
        {
            if (GamePause.isScoreStopped == true)
            {
                sIncrement += 0;
            }
            else if(GamePause.isScoreStopped == false)
            {
                sIncrement += 1;
                scoreText.text = sIncrement.ToString();
                if (sIncrement > PlayerPrefs.GetInt("HighScore", 0))
                {
                    PlayerPrefs.SetInt("HighScore", sIncrement);
                }

            } 
        }
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int sIncrement = 0;
    public Text scoreText;
    public Text highScoreText;

    void Start()
    {
        StartCoroutine(ScoreCouroutine());
    }


    IEnumerator ScoreCouroutine()
    {
        if (PlayerCollision.isDead == false)
        {
            if (GamePause.isScoreStopped == true)
            {
                sIncrement += 0;
            }
            else if (GamePause.isScoreStopped == false)
            {
                sIncrement += 3;
                scoreText.text = sIncrement.ToString();
                if (sIncrement > PlayerPrefs.GetInt("HighScore", 0))
                {
                    PlayerPrefs.SetInt("HighScore", sIncrement);
                }

            }
        }
        yield return new WaitForSeconds(.1f);
        StartCoroutine(ScoreCouroutine());
    }
}

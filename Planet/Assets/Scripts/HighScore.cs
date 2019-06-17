using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;

    private void Start()
    {
        StartCoroutine(HighScoreCouroutine());
    }

    IEnumerator HighScoreCouroutine()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        yield return new WaitForSeconds(.1f);
        StartCoroutine(HighScoreCouroutine());
    }
}

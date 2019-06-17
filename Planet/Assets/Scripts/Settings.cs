using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject mainmenuUI;
    public GameObject settingsUI;
    public Text highScoreText;
    void Start()
    {
        mainmenuUI.SetActive(true);
        settingsUI.SetActive(false);
        highScoreText.text = "0";
        StartCoroutine(HighScoreCouroutine());
    }

   

    IEnumerator HighScoreCouroutine()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        yield return new WaitForSeconds(.1f);
        StartCoroutine(HighScoreCouroutine());
    }

    public void SettingsOpen()
    {
        mainmenuUI.SetActive(false);
        settingsUI.SetActive(true);
    }

    public void SettingsClose()
    {
        settingsUI.SetActive(false);
        mainmenuUI.SetActive(true);
    }

    public void DeleteHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}

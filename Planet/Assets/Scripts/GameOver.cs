using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text highScoreUI;
    public GameObject reviveButton;
    public static int count;
    private string _rewardedVideoAdId = "rewardedVideo";

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


    public void ShowRewardedVideo()
    {
        Advertisement.Show(_rewardedVideoAdId);
    }

    void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {

        if (showResult == ShowResult.Finished)
        {
            OnceMore();
        }
        else if (showResult == ShowResult.Skipped)
        {
            return;
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
}

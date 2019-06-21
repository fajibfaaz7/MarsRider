using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdController : MonoBehaviour
{

    public static AdController adInstance;
    private string _storeId = "3190528";
    //private string _videoAdId = "video";
    private string _bannerAdId = "bannerAd";


    private void Awake()
    {
        if (adInstance == null)                                          
            adInstance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        Advertisement.Initialize(_storeId, false);
        StartCoroutine(ShowBannerAd());
    }



    IEnumerator ShowBannerAd()
    {
        while (!Advertisement.IsReady(_bannerAdId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(_bannerAdId);
    }

    
}
  


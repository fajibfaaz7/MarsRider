using UnityEngine;

public class GamePause : MonoBehaviour
{
    public GameObject pausedUI;
    public GameObject pauseUI;
    public GameObject Player;
    public GameObject Meteor;
    AudioSource audioSourceP;
    AudioSource audioSourceM;
   
    public static bool isScoreStopped = false;
    void Start()
    {
        pausedUI.SetActive(false);
        pauseUI.SetActive(true);
        audioSourceP = Player.GetComponent<AudioSource>();
        audioSourceM = Meteor.GetComponent<AudioSource>();
        audioSourceP.mute = false;
        audioSourceP.loop = true;
        audioSourceM.mute = false;
        audioSourceM.loop = true;
    }

    
    void Update()
    {
        if(PlayerCollision.isDead == true)
        {
            pauseUI.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        
        audioSourceP.mute = true;
        audioSourceP.loop = false;
        audioSourceM.mute = true;
        audioSourceM.loop = false;
        pauseUI.SetActive(false);
        Time.timeScale = 0;
        pausedUI.SetActive(true);
        isScoreStopped = true;
        
    }

    public void Resume()
    {
        audioSourceP.mute = false;
        audioSourceP.loop = true;
        audioSourceM.mute = false;
        audioSourceM.loop = true;
        pausedUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 1;
        isScoreStopped = false;
    }
}

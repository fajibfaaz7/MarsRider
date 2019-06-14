using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public void Start()
    {
        gameOverUI.SetActive(false);
    }

    public void Update()
    {
        if (PlayerCollision.isDead == true)
        {
            gameOverUI.SetActive(true);
        }
    }

}

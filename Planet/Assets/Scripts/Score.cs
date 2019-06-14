using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int sIncrement = 0;
    public Text scoreText;

    void Update()
    {
        if(PlayerCollision.isDead == false)
        {
            sIncrement++;
            scoreText.text = sIncrement.ToString();
        }
    }
}

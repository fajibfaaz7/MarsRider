using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int _sIncrement = 0;
    public Text scoreText;

    void Update()
    {
        if(PlayerCollision.isDead == false)
        {
            _sIncrement++;
            scoreText.text = _sIncrement.ToString();
        }
    }
}

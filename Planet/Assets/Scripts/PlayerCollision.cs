using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text scoreText;
    int x = 0;
    public static bool isDead = false;

    private void Start()
    {
        StartCoroutine(ScoreIncrementer());
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "CraterGroup") 
        {
            // Debug.Log(collision.collider.name);

            isDead = true;
            Destroy(this.gameObject);
            
        }
    }

    IEnumerator ScoreIncrementer()
    {
        if(isDead == false)
        {
        x += 10;
        scoreText.text = x.ToString();
        yield return new WaitForSeconds(0.3f);
        StartCoroutine(ScoreIncrementer());
        }
    }

}

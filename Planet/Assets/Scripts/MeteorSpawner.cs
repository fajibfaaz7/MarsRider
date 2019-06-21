using System.Collections;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{

    public GameObject meteorPrefab;
    

   
    void Start()
    {
        StartCoroutine(SpawnMeteorCoroutine());
    }

    IEnumerator SpawnMeteorCoroutine()
    {
        float seconds = 2f;
        float distance = Random.Range(20f, 25f);
        int score = Score.sIncrement;
        if (score < 2000)
        {
            seconds = 2f;
        }
        else if (score > 2000 && score < 5000)
        {
            seconds = 1f;
        }
        else if (score > 5000)
        {
            seconds = .5f;
        }


        Vector3 pos = Random.onUnitSphere * distance;
        Instantiate(meteorPrefab, pos, Quaternion.identity);
        yield return new WaitForSeconds(seconds);
        StartCoroutine(SpawnMeteorCoroutine());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{

    public GameObject meteorPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMeteorCoroutine());
    }

    IEnumerator SpawnMeteorCoroutine()
    {
        float seconds = 2f;
        float distance = Random.Range(20f, 25f);
        Vector3 pos = Random.onUnitSphere * distance;
        Instantiate(meteorPrefab, pos, Quaternion.identity);
        yield return new WaitForSeconds(seconds);
        StartCoroutine(SpawnMeteorCoroutine());
    }
}

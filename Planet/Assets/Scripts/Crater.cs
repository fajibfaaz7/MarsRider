using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crater : MonoBehaviour
{
    
    //void Start()
    //{
    //    StartCoroutine(DestroyCrater());
    //}

    
    void Update()
    {
        Destroy(this.gameObject, 7f);
    }

    //IEnumerator DestroyCrater()
    //{
    //    Destroy(this.gameObject);
    //    yield return new WaitForSeconds(7f);
    //}
}

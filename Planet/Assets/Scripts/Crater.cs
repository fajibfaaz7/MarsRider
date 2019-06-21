using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crater : MonoBehaviour
{

    void Update()
    {
        Destroy(this.gameObject, 7f);
    }

}

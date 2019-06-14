using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public static bool isDead = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "CraterGroup")
        {
            // Debug.Log(collision.collider.name);

            isDead = true;
            Destroy(this.gameObject);

        }
    }
}

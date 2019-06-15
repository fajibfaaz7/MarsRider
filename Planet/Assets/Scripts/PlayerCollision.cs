using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public static bool isDead = false;
    public GameObject playerDeathPrefab;
    public GameObject playerDeathEffectPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "CraterGroup")
        {
            // Debug.Log(collision.collider.name);
            Quaternion rot = Quaternion.LookRotation(transform.position.normalized);
            rot *= Quaternion.Euler(90f, 0f, 0f);
            Vector3 pos = collision.contacts[0].point;
            isDead = true;
            Handheld.Vibrate();
            Destroy(this.gameObject);
            Instantiate(playerDeathPrefab,pos,rot);
            Instantiate(playerDeathEffectPrefab, pos, rot);
            

        }
    }
}

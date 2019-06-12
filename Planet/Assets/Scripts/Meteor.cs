using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public GameObject craterPrefab;
   
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Planet")
        {
            Quaternion rot = Quaternion.LookRotation(transform.position.normalized);
            rot *= Quaternion.Euler(90f, 0f, 0f);
            Instantiate(craterPrefab, col.contacts[0].point, rot);
            Destroy(this.gameObject);
        }
    }
}

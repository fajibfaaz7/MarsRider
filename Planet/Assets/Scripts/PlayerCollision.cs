using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "CraterGroup") 
        {
           // Debug.Log(collision.collider.name);
            Destroy(this.gameObject);
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSc : MonoBehaviour
{
    private Transform target;
    public GameObject planet;
    public GameObject cra;
    
    private void Start()
    {
        target = planet.transform;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 10f * Time.deltaTime);

       
        if (Vector3.Distance(transform.position,target.position)< 1f)
        {
        target.position *= -1.0f;

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.name == "Planet")
        {
            Instantiate(cra);
            Destroy(this.gameObject);
        }
    }

}

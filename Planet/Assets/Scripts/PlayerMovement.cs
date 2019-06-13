using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 10f;

    private float _rotation;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        foreach(Touch t in Input.touches)
        {
            if(t.position.x < (Screen.width) / 2)
            {
                _rotation = -1;
            }
            else if (t.position.x > (Screen.width / 2))
            {
                _rotation = 1;
            }
            else
            {
                _rotation = 0;
            }
        }

        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        Vector3 yRotation = Vector3.up * _rotation * rotationSpeed * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(yRotation);
        Quaternion targetRotation = rb.rotation * deltaRotation;
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
        _rotation = 0;
    }
}

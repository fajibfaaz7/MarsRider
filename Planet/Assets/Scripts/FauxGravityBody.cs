using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FauxGravityBody : MonoBehaviour
{
    private FauxGravityAttractor _attractor;
    private Rigidbody rb;
    public bool placeOnSurface = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _attractor = FauxGravityAttractor.instance;
    }


    void Update()
    {
        _attractor.Attract(rb);
    }
}

using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{

    public static FauxGravityAttractor instance;
    private SphereCollider col;
    public float gravity = -10f;
    private void Awake()
    {
        instance = this;
        col = GetComponent<SphereCollider>();
    }

    public void Attract(Rigidbody body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        body.AddForce(gravityUp * gravity);
        RotateBody(body);
    }

    public void PlaceOnSurface(Rigidbody body)
    {
        body.MovePosition((body.position - transform.position).normalized * (transform.localScale.x * col.radius));

        RotateBody(body);
    }
    public void RotateBody(Rigidbody body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        Quaternion tRotation = Quaternion.FromToRotation(body.transform.up, gravityUp) * body.rotation;
        body.MoveRotation(Quaternion.Slerp(body.rotation, tRotation, 50f * Time.deltaTime));
    }
}


using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public Rigidbody rb ;
    public float forwardForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0 ,-forwardForce * Time.deltaTime);
    }
}

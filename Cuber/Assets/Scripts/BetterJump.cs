using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    public float fallMultipler, jumpMultipler;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        /*if(rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * fallMultipler;
        }
        else if (rb.velocity.y > 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * jumpMultipler;
        }*/
        Physics.gravity = new Vector3(0, -10f, 0);
    }
}

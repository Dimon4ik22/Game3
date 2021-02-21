using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed, jumpForce, nextJump;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        //Движение игрока
        transform.Translate(speed* Time.deltaTime, 0, 0);
        bool isGrounded = GroundCheck.isGrounded;
        //Прыжок игрока
        if (Input.GetKey(KeyCode.Mouse0) && isGrounded && nextJump < Time.time)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            nextJump = Time.time + 0.1f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //Проверка, на земле ли игрок
    public static bool isGrounded = false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground") && !isGrounded)
        {
            isGrounded = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}

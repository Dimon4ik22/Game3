using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    public Animator animJump;
    public Animator animFlat;
    //Анимации игрока
    void Update()
    {
        if (animJump.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Jump"))
        {
            animJump.SetBool("isJump", false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animFlat.SetTrigger("isButtonPress");
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            animFlat.SetTrigger("isButtonReleased");
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
            animJump.SetBool("isJump", false);
    }
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
            animJump.SetBool("isJump", false);
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
            animJump.SetBool("isJump", true);
    }

}

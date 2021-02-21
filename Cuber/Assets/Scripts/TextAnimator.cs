using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnimator : MonoBehaviour
{
    public Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            anim.Play();
        }
    }
}

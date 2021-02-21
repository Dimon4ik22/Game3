using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickController : MonoBehaviour
{
    public Animation anim;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            anim.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public PlayerMove move;
    public Animator anim;
    //Проверка игрока на смерть об обьект
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Destroy"))
        {
            move.enabled = false;
            anim.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("OutOfLevel"))
        {
            move.enabled = false;
            anim.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

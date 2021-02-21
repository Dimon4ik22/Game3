using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollider : MonoBehaviour
{
    public Collider[] colliders;
    public Collider needToDestroy;
    void Start()
    {
        foreach (Collider colls in colliders)
        {
            //Игнорирование коллизии
            Physics.IgnoreCollision(colls.GetComponent<Collider>(), needToDestroy.GetComponent<Collider>());
            //Импульс для разрушенного объекта
            Vector3 vec = new Vector3(8, 0, 0);
            colls.gameObject.GetComponent<Rigidbody>().AddForce(vec, ForceMode.Impulse);
        }
    }
}

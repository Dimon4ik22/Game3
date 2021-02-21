using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyablePlayer : MonoBehaviour {
	
	public GameObject ObjectNew;
	public GameObject ObjectOld;
	//Эффект разрушения после смерти
	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.CompareTag("Destroy")) {
			ObjectNew.SetActive(true);
			ObjectOld.SetActive(false);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Contains("OutOfLevel"))
		{
			ObjectNew.SetActive(true);
			ObjectOld.SetActive(false);
		}
	}
}
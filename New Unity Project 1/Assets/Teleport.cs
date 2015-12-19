using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public Transform destination;
	void OnTriggerEnter(Collider fps)
	{
		fps.transform.position = destination.transform.position;
	}

}

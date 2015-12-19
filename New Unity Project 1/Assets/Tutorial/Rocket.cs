using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
    public int ID;
	public GameObject explosion;
	public float timeOut = 4.0f;


	void Start () {
		Invoke("Kill", timeOut);
	}

	void OnCollisionEnter(Collision collision) {
		ContactPoint contact = collision.contacts[0];
		Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Instantiate (explosion, contact.point, rotation);

		Kill ();   
	}

	void Kill() {
		ParticleEmitter emitter = GetComponentInChildren<ParticleEmitter> ();
		if (emitter)
			emitter.emit = false;
		Destroy(gameObject);
	}

	}


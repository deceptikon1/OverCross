using UnityEngine;
using System.Collections;

public class RocketLauncher : MonoBehaviour {
	public Transform Rocket;

	public int ammoCount = 20;
	public float reloadTime = 0.5f;
	public AudioClip fire;


	

	void Update () {
		if (reloadTime <= 0  & Input.GetMouseButton(0) & ammoCount > 0) {
			Transform BulletInstance = (Transform) Instantiate(Rocket, GameObject.Find("Spawn").transform.position, transform.rotation); 
			BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 20000);
			reloadTime = 1;
			ammoCount--;
			AudioSource audio = GetComponent<AudioSource>();
			audio.clip = fire;
			audio.time = 3;
			audio.Play();
		}
	


		if(reloadTime>0) 
		{ 
			reloadTime -= Time.deltaTime ; 
		} 

	}
}

using UnityEngine;
using System.Collections;

public class AK47QW : MonoBehaviour {
	public int AmmoCount; // обойм 
	public int CurAmmo = 40; // Кол-во патронов 
	public int Ammo; // Кол-во патронов в 1ой обойме 
	public AudioClip Fire; // Звук выстрела 
	public float ShootSpeed; // Скорострельность 
	public float ReloadSpeed; // Скорость перезарядки   
	public AudioClip Reload; // Звук перезарядки 
	public float ReloadTimer = 0.0f; // Стандартное время перезарядки(не трогать) 
	public float ShootTimer = 0.0f; // Стандартное время выстрела(не трогать) 
	public Transform bullet; // Наш патрон


	void Start () {
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) & CurAmmo > 0 & ReloadTimer <= 0 & ShootTimer <= 0)
        {
            bullet.GetComponent<Rocket>().ID = 0;

            Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("Spawn").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 50000);
            CurAmmo = CurAmmo - 1;
            GetComponent<AudioSource>().PlayOneShot(Fire);
            ShootTimer = 0.1f;


        }
        if (ShootTimer > 0)
        {
            ShootTimer -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Reload"))
        {
            //ReloadTimer = ReloadSpeed;
            ShootTimer = 4;
            CurAmmo = Ammo;
            GetComponent<AudioSource>().PlayOneShot(Reload);
            {
                if (ShootTimer > 0)
                {
                    ShootTimer -= Time.deltaTime;
                }
            }
        }

    }
}

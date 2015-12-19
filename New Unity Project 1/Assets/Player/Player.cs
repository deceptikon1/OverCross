using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public int AmmoCount; // обойм 
    public int CurAmmo; // Кол-во патронов 
    public int Ammo; // Кол-во патронов в 1ой обойме 

    public Transform[] homePoint = new Transform[2];
    public int health = 100;
    private int IDbot;

    void Start()
    {
        AmmoCount = 10;
        Ammo = GameObject.Find("Assault_GUN").GetComponent<AK47QW>().Ammo;
        CurAmmo = Ammo;
        
    }

    void Update()
    {
        if (health <= 0)
        {
            GameObject.Find("Crossfire").GetComponent<MyGUI>().score[0,1]++;
            health = 100;

            transform.position = homePoint[(int)Random.Range(0, 2)].position;

            if (IDbot != 0)
                GameObject.Find("Crossfire").GetComponent<MyGUI>().score[IDbot, 0]++;


            CurAmmo = Ammo;
            AmmoCount = 10;
        }

    }
    public void OnTriggerEnter(Collider gun)
    {
        if (gun.tag == "gun")
        {
            health -= Random.Range(10,20);
            IDbot = gun.GetComponent<Rocket>().ID;
        }
            
    }
}

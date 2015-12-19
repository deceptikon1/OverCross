using UnityEngine;
using System.Collections;

public class PlayerWeapon1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SelectWeapon(0);
		UnityEngine.Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {

		
		if (Input.GetKeyDown("1")) {
			SelectWeapon(0);
		}	
		else if (Input.GetKeyDown("2")) {
			SelectWeapon(1);
		}	
	
	}

	void SelectWeapon(int index) {
		for (int i=0;i<transform.childCount;i++)	{
			// Activate the selected weapon
			if (i == index)
				transform.GetChild(i).gameObject.SetActive(true);
			// Deactivate all other weapons
			else
				transform.GetChild(i).gameObject.SetActive(false);
		}
	}
}

using UnityEngine;
using System.Collections;

public class SinglePlayer_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public GameObject Choose_menu;
	public ParticleSystem fire;
	Color color = new Color(0, 255, 255);
	
	
	void Start() {
		fire.Stop ();
		Choose_menu.SetActive (false);
		rend = GetComponent<Renderer>();
	}
	
	
	void OnMouseDown(){
		if (Choose_menu.activeInHierarchy == false) {
			Choose_menu.SetActive (true);
		} else if (Choose_menu.activeInHierarchy == true) {
			Choose_menu.SetActive (false);
		}
		
	}
	
	void OnMouseEnter() {
		fire.Play ();
		rend.material.color = Color.yellow;
		text.color = Color.red;

		
		
	}
	void OnMouseExit() {
		fire.Stop ();
		rend.material.color = Color.white;
		text.color = color;
	}
	
}

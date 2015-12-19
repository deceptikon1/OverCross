using UnityEngine;
using System.Collections;

public class Yes_No_Exit_menu : MonoBehaviour {

	public Renderer rend;
	public GameObject Yes_button;
	public GameObject No_button;
	public GameObject Sure_text;
	public TextMesh text;
	public ParticleSystem Fire;
	public bool Yes = false;
	public bool No = false;

	Color color = new Color(0, 255, 255);
	
	
	void Start() {
		Fire.Stop ();

		rend = GetComponent<Renderer>();
	}
	
	
	void OnMouseDown(){
		if (Yes == true) {
			Application.Quit();
		}
		if (No == true) {
			Yes_button.SetActive(false);
			No_button.SetActive(false);
			Sure_text.SetActive(false);

		}
		
	}
	
	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		text.color = Color.red;
		Fire.Play ();

		
		
	}
	void OnMouseExit() {
		rend.material.color = Color.white;
		text.color = color;
		Fire.Stop ();

	}
}

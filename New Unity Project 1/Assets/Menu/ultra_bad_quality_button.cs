using UnityEngine;
using System.Collections;

public class ultra_bad_quality_button : MonoBehaviour {

	public Renderer rend;
	public TextMesh ultra_text;
	public TextMesh bad_text;
	public bool ultra;
	public bool bad;

	void Start() {
		bad_text.gameObject.SetActive(false);
		ultra_text.gameObject.SetActive(false);
		rend = GetComponent<Renderer>();
	}

	void OnMouseDown() {
		if (ultra) {
			ultra_text.gameObject.SetActive(true);
			bad_text.gameObject.SetActive(false);
		}
		if (bad) {
			bad_text.gameObject.SetActive(true);
			ultra_text.gameObject.SetActive(false);
		}
	}

	void OnMouseEnter() {
		rend.material.color = Color.yellow;

		
		
		
	}
	void OnMouseExit() {
		rend.material.color = Color.white;

	}
}

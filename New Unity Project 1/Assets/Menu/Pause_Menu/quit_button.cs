using UnityEngine;
using System.Collections;

public class quit_button : MonoBehaviour {
	public TextMesh text;
	public bool arabic_map;
	public bool medieval_map;
	public bool castle_map;

	void OnMouseDown() {
		Application.LoadLevel (0);
	}

	void OnMouseEnter() {
		
		text.color = Color.green;
	}
	void OnMouseExit() {
		
		if(arabic_map || castle_map)
			text.color = Color.black;
		
		if(medieval_map)
			text.color = Color.white;
	}
}

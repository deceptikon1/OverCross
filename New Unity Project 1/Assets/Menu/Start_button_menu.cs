using UnityEngine;
using System.Collections;

public class Start_button_menu : MonoBehaviour {
	public TextMesh text;
	public TextMesh text_in_mapField;


	void OnMouseDown() {
		if (text_in_mapField.text == "Arabic assault") {
			Application.LoadLevel(1);
		}
		if (text_in_mapField.text == "Medieval town") {
			Application.LoadLevel(2);
		}
		if (text_in_mapField.text == "Dark Castle") {
			Application.LoadLevel(3);
		}

	}


void OnMouseEnter() {
	
	text.color = Color.red;
	
	
	
}
void OnMouseExit() {
	
	text.color = Color.green;
}
}

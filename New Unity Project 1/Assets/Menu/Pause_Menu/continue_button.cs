using UnityEngine;
using System.Collections;

public class continue_button : MonoBehaviour {
	public TextMesh text;
	public Camera fps_camera;
	public Camera pause_camera;
	GameObject qwe;
	public bool arabic_map;
	public bool medieval_map;
	public bool castle_map;
	
	void Start() {

		qwe = GameObject.Find ("Player");
	}

	void OnMouseDown() {
		UnityEngine.Cursor.visible = true;
		Time.timeScale = 1;
		qwe.SetActive(true);
		pause_camera.enabled = false;
		fps_camera.enabled = true;
        GameObject.Find("Pause_menu").GetComponent<Menu_on_game>().isPaused = false;

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

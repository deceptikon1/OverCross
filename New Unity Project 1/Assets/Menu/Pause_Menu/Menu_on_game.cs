using UnityEngine;
using System.Collections;

public class Menu_on_game : MonoBehaviour {
	public Camera camera;
	public Camera Pause_camera;
	public bool isPaused = false;
	GameObject qwe;

	void Start() {
	 qwe = GameObject.Find ("Player");
		Time.timeScale = 1.0f;
		Pause_camera.enabled = false;
		camera.enabled = true;
		qwe.SetActive(true);

		Pause_camera.enabled = false;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			if(!isPaused) {

				UnityEngine.Cursor.visible = true;
				Time.timeScale = 0.0f;
				camera.enabled = false;	
				Pause_camera.enabled = true;
				//Pause_camera.GetComponent<CC_Grayscale>().enabled = true;
				qwe.SetActive(false);

				isPaused = true;
			
			}
			else if(isPaused) {
				UnityEngine.Cursor.visible = false;
				Time.timeScale = 1.0f;
				Pause_camera.enabled = false;
				camera.enabled = true;
				qwe.SetActive(true);
				isPaused = false;

			}
		}

	
	}
}

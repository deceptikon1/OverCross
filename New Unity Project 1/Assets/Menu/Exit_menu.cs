using UnityEngine;
using System.Collections;


/// <summary> класс кнопки выхода из игры
/// <param name="rend">содержит текстуру объекта</param>
/// <param name="Exit_text">содержит текст</param>
/// <param name="Yes_button">содержит объект кнопки "да"</param>
/// <param name="No_button">содержит объект кнопки "нет"</param>
/// <param name="Quality_button">содержит объект кнопки "выбор качества"</param>
/// <param name="SinglePlayer_button">содержит объект кнопки "одиночная игра"</param>
/// <param name="MultiPlayer_button">содержит объект кнопки "мультиплеер"</param>
/// <param name="Sure_text">содержит текст</param>
/// <param name="Fire">содержит объект эффекта</param>
/// <param name="color">содержит цвет</param>
/// <param name="pressed">содержит переменную нажата ли кнопка</param>
/// </summary>
public class Exit_menu : MonoBehaviour {
	public Renderer rend;
	public TextMesh Exit_text;
	public GameObject Yes_button;
	public GameObject No_button;
	public GameObject Quality_button;
	public GameObject SinglePlayer_button;
	public GameObject MultiPlayer_button;
	public TextMesh Sure_text;
	public ParticleSystem Fire;

	Color color = new Color(0, 255, 255);
	bool pressed = false;
	

	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start() {
		Yes_button.SetActive (false);
		No_button.SetActive (false);
		Sure_text.gameObject.SetActive (false);
		Fire.Stop ();

		rend = GetComponent<Renderer>();
	}
	

	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown(){
		if (pressed == false) {
			if(Quality_button.activeInHierarchy == true)
			{
				Quality_button.SetActive(false);
			}
			if(SinglePlayer_button.activeInHierarchy == true)
			{
				SinglePlayer_button.SetActive(false);
				MultiPlayer_button.SetActive(false);

			}
			Sure_text.gameObject.SetActive (true);
			Yes_button.SetActive (true);
			No_button.SetActive (true);

			pressed = true;
		} else if (pressed == true) {
			Yes_button.SetActive (false);
			No_button.SetActive (false);
			Sure_text.gameObject.SetActive (false);
			pressed = false;
			
		}



		
	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		Exit_text.color = Color.green;
		Fire.Play ();

		
		
	}

	/// <summary>
	/// когда курсор вне объекта срабатывает эта функцияя
	/// </summary>
	void OnMouseExit() {
		rend.material.color = Color.white;
		Exit_text.color = color;
		Fire.Stop ();

	}

	
}

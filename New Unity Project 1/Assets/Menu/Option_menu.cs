using UnityEngine;
using System.Collections;


/// <summary> класс окна выбора настроек
/// <param name= "rend " >содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="SinglePlayer_button">содержит кнопку одиночная игра</param>
/// <param name="MultiPlayer_button">содержит кнопку мультиплеер</param>
/// <param name="Quality">содержит кнопку выбор качества</param>
/// <param name="Fire">содержит эффект за кнопкой</param>
/// <param name="Yes_button">содержит кнопку да</param>
/// <param name="No_button">содержит кнопку нет</param>
/// <param name="Sure_text">содержит текст</param>
/// <param name="color">содержит цвет</param>
/// <param name="pressed">содержит переменную нажата ли кнопка</param>
/// </summary>
public class Option_menu : MonoBehaviour {
	public Renderer rend;
	public GameObject Quality;
	public GameObject SinglePlayer_button;
	public GameObject MultiPlayer_button;
	public GameObject Yes_button;
	public GameObject No_button;
	public GameObject Sure_text;
	public TextMesh text;
	public ParticleSystem Fire;
	Color color = new Color(0, 255, 255);
	bool pressed = false;

	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start() {
		MultiPlayer_button.SetActive(false);
		SinglePlayer_button.SetActive(false);
		Fire.Stop ();

		Quality.SetActive (false);
		rend = GetComponent<Renderer>();
	}
	
	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown(){
		if (pressed == false) {
			if(SinglePlayer_button.activeInHierarchy == true)
			{
				SinglePlayer_button.SetActive(false);
				MultiPlayer_button.SetActive(false);
			}
			if(Yes_button.activeInHierarchy == true)
			{
				Yes_button.SetActive(false);
				No_button.SetActive(false);
				Sure_text.SetActive(false);
			}

			Quality.SetActive (true);
			pressed = true;
		} else if (pressed == true) {
			Quality.SetActive(false);
			pressed = false;
		}

	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		text.color = Color.green;
		Fire.Play ();

		
		
	}

	/// <summary>
	/// когда курсор вне объекта срабатывает эта функцияя
	/// </summary>
	void OnMouseExit() {
		rend.material.color = Color.white;
		text.color = color;
		Fire.Stop ();

	}


}

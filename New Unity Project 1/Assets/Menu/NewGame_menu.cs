using UnityEngine;
using System.Collections;


/// <summary> класс кнопки новой игры
/// <param name="rend">содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="Single">содержит кнопку одиночная игра</param>
/// <param name="Multi">содержит кнопку мультиплеер</param>
/// <param name="Quality_button">содержит кнопку выбор качества</param>
/// <param name="Fire">содержит эффект за кнопкой</param>
/// <param name="Yes_button">содержит кнопку да</param>
/// <param name="No_button">содержит кнопку нет</param>
/// <param name="Sure_text">содержит текст</param>
/// <param name="color">содержит цвет</param>
/// <param name="pressed">содержит переменную нажата ли кнопка</param>
/// </summary>
public class NewGame_menu : MonoBehaviour {
	public GameObject Single;
	public GameObject Multi;
	public GameObject Quality_button;
	public ParticleSystem Fire;
	public GameObject Yes_button;
	public GameObject No_button;
	public GameObject Sure_text;

	public TextMesh text;
	Color color = new Color(0, 255, 255);
	bool pressed = false;

	public Renderer rend;

	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start() {
		rend = GetComponent<Renderer>();
		Fire.Stop();


		Multi.SetActive (false);
		Single.SetActive (false);
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
			if(Yes_button.activeInHierarchy == true)
			{
				Yes_button.SetActive(false);
				No_button.SetActive(false);
				Sure_text.SetActive(false);
			}
			Multi.SetActive (true);
			Single.SetActive (true);
			pressed = true;
		} else if (pressed == true) {
			Multi.SetActive (false);
			Single.SetActive (false);
			pressed = false;

		}

	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		Fire.Play ();
		text.color = Color.green;
	}

	/// <summary>
	/// когда курсор вне объекта срабатывает эта функцияя
	/// </summary>
	void OnMouseExit() {
		rend.material.color = Color.white;
		Fire.Stop();

		text.color = color;


	}
}

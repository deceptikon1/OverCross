using UnityEngine;
using System.Collections;


/// <summary> класс окна выбора сложности ботов
/// <param name="rend">содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="Difficult_numField">содержит объект окна выбора сложности</param>
/// </summary>
public class DifficultField_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public GameObject Difficult_numField;

	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start () {
		Difficult_numField.SetActive (false);
		rend = GetComponent<Renderer>();
	}

	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown() {
		if (Difficult_numField.activeInHierarchy == false) {
			Difficult_numField.SetActive (true);
		} else if (Difficult_numField.activeInHierarchy == true) {
			Difficult_numField.SetActive (false);
		}
	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		text.color = Color.red;
		
		
		
	}

	/// <summary>
	/// когда курсор вне объекта срабатывает эта функцияя
	/// </summary>
	void OnMouseExit() {
		rend.material.color = Color.white;
		text.color = Color.green;
	}
}

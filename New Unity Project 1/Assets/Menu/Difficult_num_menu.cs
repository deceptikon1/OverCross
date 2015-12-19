using UnityEngine;
using System.Collections;


/// <summary> класс окна для выбора сложности ботов
/// <param name="rend">содержит текстуру объекта</param>
/// <param name="text">содержит сам текст</param>
/// <param name="text_in_difficultField">содержит текст в поле сложности ботов</param>
/// <param name="difficult_field">объект-поле выбора сложности ботов</param>
/// <param name="easy">содержит сложность ботов легкий</param>
/// <param name="normal">содержит сложность ботов средний</param>
/// <param name="hard">содержит сложность ботов тяжелый</param>
/// </summary>
public class Difficult_num_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public TextMesh text_in_difficultField;
	public GameObject difficult_field;
	public bool easy;
	public bool normal;
	public bool hard;

	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start() {
		rend = GetComponent<Renderer>();
	}

	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown() {
		if (easy) {
			text_in_difficultField.text = "easy";
		}
		if (normal) {
			text_in_difficultField.text = "normal";
		}
		if (hard) {
			text_in_difficultField.text = "hard";
		}

		difficult_field.SetActive (false);
		rend.material.color = Color.white;
		text.color = Color.green;

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

using UnityEngine;
using System.Collections;


/// <summary> класс окна выбора числа ботов
/// <param name= "rend " >содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="text_in_countField">содержит текст</param>
/// <param name="num_countField">содержит объект поля выбора числа ботов</param>
/// <param name="num_of_bots">содержит переменную количества ботов</param>
/// </summary>
public class Num_countField_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public TextMesh text_in_countField;
	public GameObject num_countField;
	public static int num_of_bots;
	public bool one;
	public bool two;
	public bool three;
	public bool four;
	public bool five;
	public bool six;
	public bool seven;
	public bool eight;


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
		if (one) {

			text_in_countField.fontSize = 40;
			//text_in_countField.transform.position = 
			text_in_countField.text = "1";
			num_of_bots = 1;
		

		}
		if (two) {
			text_in_countField.text = "2";
			num_of_bots =2;
		}
		if (three) {
			text_in_countField.text = "3";
			num_of_bots = 3;
		}
		if (four) {
			text_in_countField.text = "4";
			num_of_bots = 4;
		}
		if (five) {
			text_in_countField.text = "5";
			num_of_bots = 5;
		}
		if (six) {
			text_in_countField.text = "6";
			num_of_bots = 6;
		}
		if (seven) {
			text_in_countField.text = "7";
			num_of_bots = 7;
		}
		if (eight) {
			text_in_countField.text = "8";
			num_of_bots = 8;
		}

		num_countField.SetActive (false);
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

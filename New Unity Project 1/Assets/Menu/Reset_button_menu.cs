using UnityEngine;
using System.Collections;


/// <summary> класс кнопки сбрасывания параметров
/// <param name="text">содержит текст</param>
/// <param name="text_in_countField">содержит текст</param>
/// <param name="text_in_difficultField">содержит текст</param>
/// <param name="text_in_mapField">содержит текст</param>
/// <param name="count_numField">содержит объект окна</param>
/// <param name="difficult_numField">содержит объект окна</param>
/// <param name="map_numField">содержит объект окна</param>
/// </summary>
public class Reset_button_menu : MonoBehaviour {
	
	public TextMesh text;
	public TextMesh text_in_countField;
	public TextMesh text_in_difficultField;
	public TextMesh text_in_mapField;
	public GameObject count_numField;
	public GameObject difficult_numField;
	public GameObject map_numField;


	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown() {
		text_in_countField.text = ". . .";
		text_in_difficultField.text = ". . .";
		text_in_mapField.text = ". . .";
		count_numField.SetActive (false);
		difficult_numField.SetActive (false);
		map_numField.SetActive (false);

	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter() {

		text.color = Color.red;
		
		
		
	}

	/// <summary>
	/// когда курсор вне объекта срабатывает эта функцияя
	/// </summary>
	void OnMouseExit() {

		text.color = Color.green;
	}
}

using UnityEngine;
using System.Collections;


/// <summary> класс окна выбора пунктов карты
/// <param name="rend">содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="MapField">содержит объект окна</param>
/// <param name="text_in_MapField">содержит текст</param>
/// <param name="Arabic_map">содержит переменную что именно за карта в данный момент</param>
/// <param name="Medieval_map">содержит переменную что именно за карта в данный момент</param>
/// <param name="Castle_map">содержит переменную что именно за карта в данный момент</param>
/// </summary>
public class mapField_num_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public TextMesh text_in_MapField;
	public GameObject MapField;
	public bool Arabic_map;
	public bool Medieval_map;
	public bool Castle_map;


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
		if (Arabic_map) {
			text_in_MapField.text = "Arabic assault";
		}
		if (Medieval_map) {
			text_in_MapField.text = "Medieval town";
		}
		if (Castle_map) {
			text_in_MapField.text = "Dark Castle";
		}
		
		MapField.SetActive (false);
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

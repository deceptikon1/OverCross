using UnityEngine;
using System.Collections;


/// <summary> класс окна выбора карты
/// <param name="rend">содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="Map_numField">содержит объект окна</param>
/// </summary>
public class MapField_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public GameObject Map_numField;
	
	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start () {
		Map_numField.SetActive (false);
		rend = GetComponent<Renderer>();
	}

	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown() {
		if (Map_numField.activeInHierarchy == false) {
			Map_numField.SetActive (true);
		} else if (Map_numField.activeInHierarchy == true) {
			Map_numField.SetActive (false);
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

using UnityEngine;
using System.Collections;



/// <summary> класс окна выбора числа ботов
/// <param name= "rend " >содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="Count_numField">содержит объект окна</param>
/// </summary>
public class CountField_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public GameObject Count_numField;

	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start ()
	{
		Count_numField.SetActive (false);
		rend = GetComponent<Renderer>();
	}

	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown()
	{
		if (Count_numField.activeInHierarchy == false) {
			Count_numField.SetActive (true);
		} else if (Count_numField.activeInHierarchy == true) {
			Count_numField.SetActive (false);
		}
	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter()
	{
		rend.material.color = Color.yellow;
		text.color = Color.red;
	}

	/// <summary>
	/// когда курсор вне объекта срабатывает эта функцияя
	/// </summary>
	void OnMouseExit()
	{
		rend.material.color = Color.white;
		text.color = Color.green;
	}
}

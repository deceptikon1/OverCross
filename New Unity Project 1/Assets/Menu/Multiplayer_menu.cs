using UnityEngine;
using System.Collections;


/// <summary> класс окна мультиплеера
/// <param name="rend">содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="fire">содержит объект эффекта за кнопкой</param>
/// <param name="color">содержит цвет</param>
/// </summary>
public class Multiplayer_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public ParticleSystem fire;

	Color color = new Color(0, 255, 255);
	
	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start() {
		
		fire.Stop ();
		rend = GetComponent<Renderer>();
	}
	
	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown(){

		
	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		text.color = Color.red;
		fire.Play ();
		
		
		
	}

	/// <summary>
	/// когда курсор вне объекта срабатывает эта функцияя
	/// </summary>
	void OnMouseExit() {
		rend.material.color = Color.white;
		text.color = color;
		fire.Stop ();
	}
}

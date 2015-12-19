using UnityEngine;
using System.Collections;


/// <summary> класс кнопки выбора качества изображения
/// <param name= "rend " >содержит текстуру объекта</param>
/// <param name="text">содержит текст</param>
/// <param name="quality_fieldMenu">содержит объект окна</param>
/// <param name="Fire">содержит эффект кнопки</param>
/// </summary>
public class Quality_menu : MonoBehaviour {

	public Renderer rend;
	public TextMesh text;
	public ParticleSystem Fire;
	public GameObject quality_fieldMenu;


	Color color = new Color(0, 255, 255);
	
	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start() {
		Fire.Stop ();
		quality_fieldMenu.SetActive (false);
		rend = GetComponent<Renderer>();
	}
	
	/// <summary>
	/// если нажать на объект срабатывает функция
	/// </summary>
	void OnMouseDown(){
		if(quality_fieldMenu.activeInHierarchy == false)
		quality_fieldMenu.SetActive (true);
		else if (quality_fieldMenu.activeInHierarchy == true)
			quality_fieldMenu.SetActive (false);
		
	}

	/// <summary>
	/// когда курсор попадает в объект срабатывает функция
	/// </summary>
	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		text.color = Color.red;
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
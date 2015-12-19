using UnityEngine;
using System.Collections;

/// <summary>
/// класс здоровья бота
/// <param name="myHealth">количество здоровья бота</param>
/// <param name="isLife">состояние жизни бота жив/мертв</param>
/// </summary>
public class BotHealth : MonoBehaviour {
	public int myHealth = 100;
	private bool isLife = true;
	
	/// <summary>
	/// функция задает боту начальное здоровье
	/// </summary>
	void Start() {
		if (myHealth < 0)
			myHealth = 100;
	}
	
	/// <summary>
	/// функция изменения здоровья
	/// </summary>
	/// <param name="health">переменная, показывающая на
	/// сколько изменяется здоровье бота</param>
	/// <param name="gun">коллайдер патрона попавшего в бота</param>
	public void adjustHealth(int health, Collider gun) {
		isLife = true;
		myHealth += health;
		
		if (myHealth < 0)
			myHealth = 0;
		
		if (myHealth == 0) {
			isLife = false;
			
			if (gun.GetComponent<Rocket>().ID == 0)
				GameObject.Find("Crossfire").GetComponent<MyGUI>().score[gun.GetComponent<Rocket>().ID, 0]++;   
		}
	}
	
	/// <summary>
	/// функция возвращающая состояние бота
	/// </summary>
	/// <returns>сщстояние бота</returns>
	public bool getIsLife() {
		return isLife;
	}
	
	/// <summary>
	/// функция возвращающая количество здоровья бота
	/// </summary>
	/// <returns>количество здоровья бота</returns>
	public int getHealth() {
		return myHealth;
	}
}


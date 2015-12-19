using UnityEngine;
using System.Collections;

/// <summary> класс триггера для бота
/// <param name="bot">содержит самого бота</param>
/// <param name="ai">элемент класса BotAI</param>
/// </summary>
public class BotTrigger : MonoBehaviour
{
	public Transform bot;
	private BotAI ai;
	
	/// <summary>
	/// функция, выполняющаяся при запуске игры
	/// </summary>
	void Start()
	{
		ai = bot.GetComponent<BotAI>();
	}
	
	/// <summary>
	/// когда коллайдер попадает в тригер бота, срабатывает эта функция
	/// </summary>
	/// <param name="other">коллайдер, который попал в триггер бота</param>
	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			ai.SetTarget(other.transform);
		}
	}
	
	/// <summary>
	/// когда коллайдер выходит из тригера бота, срабатывает эта функция
	/// </summary>
	/// <param name="other">коллайдер, который вышел из триггера бота</param>
	public void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			ai.SetTarget(ai.homePoint[(int)Random.Range(0,2)].transform);
		}
	}
}
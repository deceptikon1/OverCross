using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BotMovement))]

/// <summary>
/// класс интелекта бота
/// <param name="deaded">состояние жизни бота жив/мертв</param>
/// <param name="target">цель бота</param>
/// <param name="motor">объект передвижений бота</param>
/// <param name="eh">объект хдоровья бота</param>
/// <param name="homePoint">массив респаунов</param>
/// </summary>
public class BotAI : MonoBehaviour
{
	private bool deaded = false;
	
	private Transform target;
	private BotMovement motor;
	private BotHealth eh;
	
	public Transform[] homePoint = new Transform[2];
	
	/// <summary>
	/// задает изначальную цель бота и инициализирует переменные 
	/// </summary>
	void Start()
	{
		target = homePoint[1];
		
		motor = this.GetComponent<BotMovement>();
		eh = this.GetComponent<BotHealth>();
	}
	
	/// <summary>
	/// если бот мертв, отправляет сообщение об этом
	/// </summary>
	void Update()
	{
		if (eh.getIsLife())
		{
		}
		else
		{
			if (!deaded)
			{
				eh.adjustHealth(100, GetComponent<SphereCollider>());
				SendMessage("Death");
			}
		}
	}
	
	/// <summary>
	/// устанавливает цель бота
	/// </summary>
	/// <param name="tgt">будущая цель бота</param>
	public void SetTarget(Transform tgt)
	{
		target = tgt;
		motor.SetTarget(target);
	}
	
	/// <summary>
	/// наносит урон боту, когда патрон врезается в бота
	/// </summary>
	/// <param name="gun">коллайдер патрона</param>
	public void OnTriggerEnter(Collider gun)
	{
		if (gun.tag == "gun")
		{
			eh.adjustHealth(-(int)Random.Range(10, 20), gun);
		}
		
	}
}

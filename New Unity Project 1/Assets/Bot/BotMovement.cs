using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(NavMeshAgent))]

/// <summary> класс джижений бота
/// <param name="ammoCount">количество обойм бота</param>
/// <param name="curAmmo">текущее количество патронов бота</param>
/// <param name="ammo">количество патронов в 1ой обойме</param>
/// <param name="fire">звук выстрела</param>
/// <param name="shootSpeed">скорострельность</param>
/// <param name="reloadSpeed"> скорость перезарядки</param>
/// <param name="reload">звук перезарядки</param>
/// <param name="reloadTimer">время перезарядки</param>
/// <param name="shootTimer">время выстрела</param>
/// <param name="bullet">патрон</param>
/// <param name="maxDistance">максимальная дистанция на которую может подойти бот к игроку</param>
/// <param name="rotationSpeed">скорость поворота бота</param>
/// <param name="animIdle">анимация покоя бота</param>
/// <param name="animRun">анимация бега бота</param>
/// <param name="animShoot">анимация выстрела бота</param>
/// <param name="ID">идентификатор бота</param>
/// <param name="target">цель бота, куда он собирается идти</param>
/// <param name="navMeshAgent">объект navMeshAgent бота</param>
/// <param name="deaded">переменная, показывающая умер бот или нет</param>
/// </summary>
public class BotMovement : MonoBehaviour {
	
	public int ammoCount;
	public int curAmmo; 
	public int ammo;  
	public AudioClip fire; 
	public float shootSpeed;
	public float reloadSpeed;   
	public AudioClip reload;
	public float reloadTimer = 0.0f;
	public float shootTimer = 0.0f;
	public Transform bullet;
	
	
	public float maxDistance = 3.0f;
	
	public float rotationSpeed = 3f;
	
	public AnimationClip animIdle;
	public AnimationClip animRun;
	public AnimationClip animShoot;
	
	public int ID;
	private Transform target;
	private NavMeshAgent navMeshAgent;
	private bool deaded = false;
	
	/// <summary>
	/// здесь мы инициализируем переменные
	/// </summary>
	void Start()
	{
		navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
		
		target = gameObject.GetComponent<BotAI>().homePoint[1];
		
		GetComponent<Animation>().wrapMode = WrapMode.Loop;
		GetComponent<Animation>().Stop();
		GetComponent<Animation>().CrossFade(animIdle.name);
	}
	
	/// <summary>
	/// здесь описанны передвижения бота
	/// </summary>
	void Update()
	{
		if (!deaded)
		{
			if (target != null)
			{
				float distance = Vector3.Distance(target.position, transform.position);
				
				Vector3 direction = transform.TransformDirection(Vector3.forward);
				
				RaycastHit hit;
				
				Physics.Raycast(transform.position, direction, out hit, 100000f);
				
				
				
				Vector3 newDir = Vector3.RotateTowards(transform.forward, target.position - transform.position, rotationSpeed, 0.0F);
				transform.rotation = Quaternion.LookRotation(newDir);
				
				if (hit.transform.tag == "Player")
				{
					Stop();
					Attack();
				}
				else if (distance >= maxDistance)
				{
					Run();              
				}
				else
				{
					Stop();
				}
			}
			else
			{
				Stop();
			}
		}
	}
	
	/// <summary>
	/// функция устанавливает цель для бота
	/// </summary>
	/// <param name="target">будущая цель бота</param>
	public void SetTarget(Transform target)
	{
		this.target = target;
	}
	
	/// <summary>
	/// функция бега бота
	/// </summary>
	private void Run()
	{
		GetComponent<Animation>().CrossFade(animRun.name);
		
		navMeshAgent.Resume();
		navMeshAgent.SetDestination(target.position);
	}
	
	/// <summary>
	/// функция остановки бота
	/// </summary>
	private void Stop()
	{
		GetComponent<Animation>().CrossFade(animIdle.name);
		
		navMeshAgent.Stop();
		
		if(target.transform.tag != "Player")
			SetTarget(gameObject.GetComponent<BotAI>().homePoint[(int)Random.Range(0, 2)]);
	}
	
	/// <summary>
	/// функция стрельбы бота
	/// </summary>
	void Attack()
	{
		
		GetComponent<Animation>().CrossFade(animShoot.name);
		
		if (curAmmo > 0 & reloadTimer <= 0 & shootTimer <= 0)
		{
			bullet.GetComponent<Rocket>().ID = ID;
			
			Transform BulletInstance = (Transform)Instantiate(bullet, transform.GetChild(4).transform.position, Quaternion.identity);
			BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 50000);
			curAmmo = curAmmo - 1;
			GetComponent<AudioSource>().PlayOneShot(fire);
			shootTimer = 0.1f;
			
			
		}
		if (shootTimer > 0)
		{
			shootTimer -= Time.deltaTime;
		}
		
		if (curAmmo <= 0)
		{
			shootTimer = 4;
			curAmmo = ammo;
			GetComponent<AudioSource>().PlayOneShot(reload);
			{
				if (shootTimer > 0)
				{
					shootTimer -= Time.deltaTime;
				}
			}
		} 
		
	}
	
	/// <summary>
	/// функция смерти, респауна бота
	/// </summary>
	void Death() {
		GameObject.Find("Crossfire").GetComponent<MyGUI>().score[ID, 1]++;
		
		target = GameObject.Find("Player").transform;
		transform.position = gameObject.GetComponent<BotAI>().homePoint[(int)Random.Range(0, 2)].position;
		
		curAmmo = ammo;
		ammoCount = 10;
	}
}


using UnityEngine;
using System.Collections;

/// <summary> класс изменения курсора
/// <param name="Cursors">содержит текстуры курсора</param>
/// <param name="TimeChange">переменная изменения времени</param>
/// <param name="cur">ntr</param>
/// </summary>
public class Cursor : MonoBehaviour {
	public Texture2D[] Cursors;

	private int i;
	public float TimeChange;

	private Texture2D cur;
	private float TimerDown;

	void Start () {
		TimerDown = TimeChange;

	}
	

	void Update () {
		UnityEngine.Cursor.visible = true;


	}



  
}

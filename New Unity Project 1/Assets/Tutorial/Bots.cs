using UnityEngine;
using System.Collections;

public class Bots : MonoBehaviour {
	public GameObject bot_1;
	public GameObject bot_2;
	public GameObject bot_3;
	public GameObject bot_4;
	public GameObject bot_5;
	public GameObject bot_6;
	public GameObject bot_7;
	public GameObject bot_8;
	public int count1;

	
	void Start () {
		count1 = Num_countField_menu.num_of_bots;


		if (count1 == 1) {
			bot_1.SetActive(true);
			bot_2.SetActive(false);
			bot_3.SetActive(false);
			bot_4.SetActive(false);
			bot_5.SetActive(false);
			bot_6.SetActive(false);
			bot_7.SetActive(false);
			bot_8.SetActive(false);
		}

		else if (count1 == 2) {
			bot_1.SetActive(true);
			bot_2.SetActive(true);
			bot_3.SetActive(false);
			bot_4.SetActive(false);
			bot_5.SetActive(false);
			bot_6.SetActive(false);
			bot_7.SetActive(false);
			bot_8.SetActive(false);
		}

		else if (count1 == 3) {
			bot_1.SetActive(true);
			bot_2.SetActive(true);
			bot_3.SetActive(true);
			bot_4.SetActive(false);
			bot_5.SetActive(false);
			bot_6.SetActive(false);
			bot_7.SetActive(false);
			bot_8.SetActive(false);
		}

		else if (count1 == 4) {
			bot_1.SetActive(true);
			bot_2.SetActive(true);
			bot_3.SetActive(true);
			bot_4.SetActive(true);
			bot_5.SetActive(false);
			bot_6.SetActive(false);
			bot_7.SetActive(false);
			bot_8.SetActive(false);
		}

		else if (count1 == 5) {
			bot_1.SetActive(true);
			bot_2.SetActive(true);
			bot_3.SetActive(true);
			bot_4.SetActive(true);
			bot_5.SetActive(true);
			bot_6.SetActive(false);
			bot_7.SetActive(false);
			bot_8.SetActive(false);
		}

		else if (count1 == 6) {
			bot_1.SetActive(true);
			bot_2.SetActive(true);
			bot_3.SetActive(true);
			bot_4.SetActive(true);
			bot_5.SetActive(true);
			bot_6.SetActive(true);
			bot_7.SetActive(false);
			bot_8.SetActive(false);
		}

		else if (count1 == 7) {
			bot_1.SetActive(true);
			bot_2.SetActive(true);
			bot_3.SetActive(true);
			bot_4.SetActive(true);
			bot_5.SetActive(true);
			bot_6.SetActive(true);
			bot_7.SetActive(true);
			bot_8.SetActive(false);
		}

		else if (count1 == 8) {
			bot_1.SetActive(true);
			bot_2.SetActive(true);
			bot_3.SetActive(true);
			bot_4.SetActive(true);
			bot_5.SetActive(true);
			bot_6.SetActive(true);
			bot_7.SetActive(true);
			bot_8.SetActive(true);
		}


	
	}
	

}

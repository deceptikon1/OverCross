using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour
{
    public Texture2D crosshairTexture;
    private Rect position;
    private GUIStyle font;

    public int numPlayers;
    public int[,] score; 

    void Start()
    {
        numPlayers = Num_countField_menu.num_of_bots + 1;
        for (int i = 1; i < numPlayers; i++)
            GameObject.Find("bot" + (i - 1).ToString()).GetComponent<BotMovement>().ID = i;


        font = new GUIStyle();
        font.fontSize = 20;
        position = new Rect((Screen.width - crosshairTexture.width) / 2, (Screen.height - crosshairTexture.height) / 2, crosshairTexture.width, crosshairTexture.height);

        score = new int[numPlayers,2];

        for (int i = 0; i < numPlayers; i++)
            for (int j = 0; j < 2; j++)
                score[i,j] = 0;
    }

    public void OnGUI()
    {
        if (!GameObject.Find("Pause_menu").GetComponent<Menu_on_game>().isPaused)
        {
            GUI.DrawTexture(position, crosshairTexture);

            GUI.Label(new Rect(10, 10, 200, 200), "Health", font);
            GUI.Label(new Rect(10, 30, 200, 200), GameObject.Find("Player").GetComponent<Player>().health.ToString(), font);

            GUI.Label(new Rect(90, 10, 200, 200), "Ammo", font);
            GUI.Label(new Rect(90, 30, 200, 200), GameObject.Find("Assault_GUN").GetComponent<AK47QW>().CurAmmo.ToString(), font);

            if (Input.GetKey("tab"))
            {
                GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
                GUI.Label(new Rect(180, 100, 210, 370), "KILL", font);
                GUI.Label(new Rect(250, 100, 300, 370), "DEATH", font);
                GUI.Label(new Rect(100, 120, 150, 350), "I am", font);


                for (int i = 0; i < numPlayers; i++)
                    for (int j = 0; j < 2; j++)
                    {
                        GUI.Label(new Rect(180 + j * 70, 120 + i * 20, 210 + j * 70, 370 + i * 20), score[i, j].ToString(), font);
                        if(i != 0)
                            GUI.Label(new Rect(100, 120 + i * 20, 150, 370 + i * 20), "BOT" + i.ToString(), font);
                    }
                       
            }
        }
    }
}

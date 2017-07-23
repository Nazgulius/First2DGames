using System.Collections;
using UnityEngine;

public class menu : MonoBehaviour
{
	private int _window = 0;

	void OnGUI ()
	{  // проверка работы комментария
		if (_window == 0) {
			GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 180), "Main Menu");

			if (GUI.Button (new Rect (Screen.width / 2 - 90, Screen.height / 2 - 80, 180, 30), "Play")) {
				Application.LoadLevel (1);
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 90, Screen.height / 2 + 40,	180, 30), "Exit")) {
				Application.Quit ();
			}
		}

	}

}

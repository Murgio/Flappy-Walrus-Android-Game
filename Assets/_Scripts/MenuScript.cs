﻿using UnityEngine;
using System.Collections;

/**
 * Created by Muriz on 14.02.14 
 */

public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;

		if (GUI.Button(new Rect(
						Screen.width / 2 - (buttonWidth / 2),
						(2 * Screen.height / 3) - (buttonHeight / 2),
						buttonWidth,
						buttonHeight),
			"Start")) {

			Application.LoadLevel("scene");
		}
	}
}
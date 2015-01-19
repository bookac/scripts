﻿using UnityEngine;
using System.Collections;

public class OpenPopUpButton : MonoBehaviour {

	public GameObject PopUp;
	public GameObject BG_Dark_Sprite;

	void OnClick()
	{
		transform.animation.Play ("Button_Pressed");
		PopUp.animation.Play ("PopUp_Open");
		BG_Dark_Sprite.SetActive (true);
		PopUp.SetActive (true);
	}
}
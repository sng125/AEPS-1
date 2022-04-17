using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using TMPro;

public class WinCondition : MonoBehaviour
{
	
	public TextMeshProUGUI winTextObject;
	private bool hitOnce = true;
	
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Ground" && hitOnce)
		{
			winTextObject.text = "You Lose";
			winTextObject.color = new Color(255, 0, 0, 255);
			hitOnce = false;
		}
		if (col.gameObject.name == "Target" && hitOnce)
		{
			winTextObject.text = "You Win!";
			winTextObject.color = new Color(229, 220, 0, 255);
			hitOnce = false;
		}
	}
}

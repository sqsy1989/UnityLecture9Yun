﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoremanger : MonoBehaviour {

	public static int score;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		score = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "Score: " + score;
	}


	public static void RefreshPoint(int point)
	{
		score = point;
	}


}

﻿using UnityEngine;
using System.Collections;

public class splashScript : MonoBehaviour {
	public float timer = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0) {
			timer = float.PositiveInfinity;
			Application.LoadLevelAdditive(Application.loadedLevel+1);
		}
	}
}

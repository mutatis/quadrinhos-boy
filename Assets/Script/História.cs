﻿using UnityEngine;
using System.Collections;

public class História : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Application.LoadLevel ("Tutorial"); 
		}
	}
}
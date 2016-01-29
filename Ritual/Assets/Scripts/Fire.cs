﻿using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	FireCounter fireCtr;
	int maxFire;

	void Awake() {
		fireCtr = GameObject.Find("FireGUI").GetComponent<FireCounter>();
	}

	void Start () {
		maxFire = 1;
	}
	
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			fireCtr.fireNum = maxFire;
		}
	}
}
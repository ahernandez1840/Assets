﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject prefab;
	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {



		
			Instantiate (prefab, spawnPoint.position, Quaternion.identity);
		}

	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBrokenPiece : MonoBehaviour {

    public float destroyTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, destroyTime);
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {

   

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterControls>().maxSpeed /= 3;
        }

        //Camera.main.GetComponent<CameraScript>().translate *= 2;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterControls>().maxSpeed *= 3;
        }

        //Camera.main.GetComponent<CameraScript>().translate /= 2;
    }
}

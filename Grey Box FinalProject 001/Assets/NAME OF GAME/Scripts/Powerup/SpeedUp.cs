using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour {

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
            other.gameObject.GetComponent<CharacterControls>().maxSpeed *= 2;
            other.gameObject.GetComponent<CharacterControls>().speed *= 2;
        }

        Camera.main.GetComponent<CameraScript>().translate *= 3;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterControls>().maxSpeed /= 2;
            other.gameObject.GetComponent<CharacterControls>().speed /= 2;
        }

        Camera.main.GetComponent<CameraScript>().translate /= 3;
    }
}

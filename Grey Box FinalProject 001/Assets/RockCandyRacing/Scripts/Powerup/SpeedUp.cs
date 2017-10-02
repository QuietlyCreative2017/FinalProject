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
            other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.GetComponent<CharacterControls>().forceForward * 10);
        }

        Camera.main.GetComponent<CameraScript>().translate *= 6;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
        }

        Camera.main.GetComponent<CameraScript>().translate /= 3;
    }
}

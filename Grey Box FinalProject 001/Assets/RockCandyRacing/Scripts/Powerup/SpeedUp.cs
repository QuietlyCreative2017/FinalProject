using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour {

    [Tooltip("Speed increase whilst in zone")]
    public float InitialSpeedAmount;
    [Tooltip("Speed increase as you leave the zone(to shoot out)")]
    public float ExitSpeedAmount;

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
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(InitialSpeedAmount, 0, 0));
        }

        Camera.main.GetComponent<CameraScript>().translate *= 6;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(ExitSpeedAmount, 0, 0));
        }

        Camera.main.GetComponent<CameraScript>().translate /= 3;
    }
}

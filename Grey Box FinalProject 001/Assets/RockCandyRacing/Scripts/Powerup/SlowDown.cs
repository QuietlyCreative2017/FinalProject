using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {

    public float SlowToPercent;

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
            CharacterControls colControls = other.gameObject.GetComponent<CharacterControls>();
            colControls.Slow(2);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CharacterControls colControls = other.gameObject.GetComponent<CharacterControls>();
        }
        
    }
}

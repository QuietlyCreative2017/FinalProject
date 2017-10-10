using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void onTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            
        }
    }
}

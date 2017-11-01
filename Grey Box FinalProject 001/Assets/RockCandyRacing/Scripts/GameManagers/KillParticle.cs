using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillParticle : MonoBehaviour {

    private ParticleSystem PC;

	// Use this for initialization
	void Start () {
        PC = gameObject.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(PC.isStopped)
        {
            Destroy(gameObject);
        }	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCreditsUP : MonoBehaviour {

    public float moveUpSpeed = 0.1f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         //transform.position = transform.position + new Vector3(0, moveUpSpeed * Time.deltaTime, 0);
        transform.Translate(new Vector3(0, moveUpSpeed * Time.deltaTime, 0));
	}
}

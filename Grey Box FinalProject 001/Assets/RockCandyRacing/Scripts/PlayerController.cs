using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int moveSpeed;

	public int jumpHeight;

	public KeyCode leftButton;

	public KeyCode rightButton;

	public KeyCode jumpButton;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(rightButton)){
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * moveSpeed);
		}
		if (Input.GetKey(leftButton)){
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * -moveSpeed);
		}
		if (Input.GetKey(jumpButton)){
			gameObject.GetComponent<Rigidbody>().AddForce(transform.up * jumpHeight);
		}

	}
}

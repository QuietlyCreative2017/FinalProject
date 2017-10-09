using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketUpdate : MonoBehaviour {

    Vector3 direction;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        direction = new Vector3(0, -2, 0);
        direction *= speed * Time.deltaTime;
        transform.Translate(direction);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<CharacterControls>().Slow();
        }
    }
}

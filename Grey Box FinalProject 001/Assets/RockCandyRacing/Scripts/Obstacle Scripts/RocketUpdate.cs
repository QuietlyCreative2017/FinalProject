using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketUpdate : MonoBehaviour {

    Vector3 direction;
    public float speed;
    float deadTime = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        deadTime -= Time.deltaTime;
        direction = new Vector3(0, -2, 0);
        direction *= speed * Time.deltaTime;
        transform.Translate(direction);

        //if the rocket has been on screen for deadTime destroy it
        if(deadTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    //check for collision with a player
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if(collision.gameObject.tag == "Player")
        {
            //slow the player it hits
            collision.gameObject.GetComponent<CharacterControls>().Slow();
        }
    }
}

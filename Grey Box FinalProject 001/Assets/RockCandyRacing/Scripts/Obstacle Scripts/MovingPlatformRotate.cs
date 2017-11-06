using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformRotate : MonoBehaviour {

    public float point2Yoffset;
    public float speed;
    float destination;
    bool reachedPos;

    // Use this for initialization
    void Start () {
         destination = transform.position.y + point2Yoffset;
	}
	
	// Update is called once per frame
	void Update () {

        if(!reachedPos)
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, destination, transform.position.z), speed * Time.deltaTime);

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, destination - point2Yoffset, transform.position.z), speed * Time.deltaTime);
        }

        if(transform.position.y == destination)
        {
            reachedPos = true;
        }

        if(transform.position.y == destination - point2Yoffset)
        {
            reachedPos = false;
        }
    }
}

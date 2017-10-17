using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketUpdate : MonoBehaviour
{

    Vector3 direction;
    public float speed;
    float deadTime = 5.0f;
    bool foundEnemy = false;
    GameObject Enemy = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        deadTime -= Time.deltaTime;
        //if (foundEnemy)
        //{
        //    transform.LookAt(Enemy.transform);
        //    transform.Rotate(new Vector3(90, 270, 90));
        //    transform.Translate(-Vector3.up * speed * Time.deltaTime);
        //}
        //else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        //if the rocket has been on screen for deadTime destroy it
        if (deadTime <= 0)
        {
            Destroy(gameObject);
        }

    }

    //check for collision with a player
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
            //slow the player it hits
            collision.gameObject.GetComponent<CharacterControls>().Slow();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            foundEnemy = true;
            Enemy = col.gameObject;
        }
    }

   private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            foundEnemy = false;
        }
    }
}

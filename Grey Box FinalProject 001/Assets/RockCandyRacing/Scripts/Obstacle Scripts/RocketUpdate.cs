using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketUpdate : MonoBehaviour
{

    Vector3 direction;
    public float speed;
    public float deadTime = 5.0f;
    bool foundEnemy = false;
    GameObject Enemy = null;
    public float followDeadTime = 0.0f;
    public bool homing = true;
    public float SlerpTime;

    Transform rotNeeded;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //deadTime -= Time.deltaTime;
        if (homing)
        {
            if (foundEnemy)
            {
                //if (followDeadTime > 0)
                //{
                //followDeadTime -= Time.deltaTime;
                //Quaternion rotNeeded = Quaternion.LookRotation(Enemy.transform.position/* + new Vector3(90, 270, 90)*/);
                //Quaternion asad = Quaternion.Euler(0, 0, 90);
                //rotNeeded *= asad;
                //transform.rotation = Quaternion.Slerp(transform.rotation, rotNeeded, 0.2f);

                //rotNeeded = this.transform;
                //rotNeeded.LookAt(Enemy.transform);
                //rotNeeded.Rotate(new Vector3(0, -90, 0));

                Quaternion rotNeeded = Quaternion.LookRotation(Enemy.transform.position);

                transform.rotation = Quaternion.Lerp(transform.rotation, rotNeeded, 0.02f);
                //}
                
                //if(followDeadTime <= 0)
                //{
                //    foundEnemy = false;
                //}
            }
            else
            {
            }

        }
        else
        {
        }

        transform.Translate(Vector3.right * speed * Time.deltaTime);

        //if the rocket has been on screen for deadTime destroy it
        if (deadTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    //check for collision with a player
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
            //slow the player it hits
            collision.gameObject.GetComponent<CharacterControls>().Slow();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //homing = false;
            foundEnemy = true;
            Enemy = col.gameObject;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            foundEnemy = false;
        }
    }
}

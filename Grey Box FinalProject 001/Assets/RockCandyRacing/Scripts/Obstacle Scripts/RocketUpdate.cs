﻿using System.Collections;
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

    public Vector3 v3Rotation;

    public GameObject ParticleEffect;

    Transform rotNeeded;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        deadTime -= Time.deltaTime;
        if (homing)
        {
            if (foundEnemy)
            {
                
            }
            else
            {
            }

        }
        else
        {
        }

        transform.Translate(Vector3.right * speed * Time.deltaTime);
        RotateRocket();

        //if the rocket has been on screen for deadTime destroy it
        if (deadTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    //check for collision with a player
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(ParticleEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
            //slow the player it hits
            collision.gameObject.GetComponent<CharacterControls>().StartCoroutine(collision.gameObject.GetComponent<CharacterControls>().Vibrate(1));
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

    private void RotateRocket()
    {
        transform.Rotate(v3Rotation.x, v3Rotation.y, v3Rotation.z);
    }
}

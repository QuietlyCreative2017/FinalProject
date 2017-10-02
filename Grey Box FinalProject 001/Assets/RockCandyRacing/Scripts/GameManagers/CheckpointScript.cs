using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{

    GameObject[] player;
    public bool toggled = false;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 2; i++)
        {
            if (player[i].transform.position.x >= gameObject.transform.position.x)
            {
                if (toggled == false)
                {
                    gameObject.transform.Rotate(new Vector3(0, 180, 0));
                    toggled = true;
                }
            }

        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    gameObject.transform.Rotate(new Vector3(0, 180, 0));
    //}
}

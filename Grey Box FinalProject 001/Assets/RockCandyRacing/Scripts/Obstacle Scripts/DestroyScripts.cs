using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScripts : MonoBehaviour
{

    public GameObject brokenThing;
    bool spawn;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        // Instantiate(brokenThing, gameObject.transform);
        spawn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        player = collision.gameObject;
        if (!spawn)
        {
            Instantiate(brokenThing, gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            spawn = true;
        }
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<CharacterControls>().Slow();
            //collision.gameObject.GetComponent<CharacterControls>().StartCoroutine("stun");
        }

       
    }
}

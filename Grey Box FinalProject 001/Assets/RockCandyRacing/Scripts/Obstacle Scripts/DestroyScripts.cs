using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScripts : MonoBehaviour
{

    public GameObject brokenThing;
    bool spawn;

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
        //slow collision if it's a player
        if (collision.gameObject.tag == "Player")
        {
            if (!spawn)
            {
                //spawn broken thing
                Instantiate(brokenThing, gameObject.transform.position, new Quaternion(0, 0, 0, 0));
                spawn = true;
            }
            Destroy(gameObject);
            CharacterControls ColControls = collision.gameObject.GetComponent<CharacterControls>();
            ColControls.StartCoroutine(ColControls.Vibrate(1));
            ColControls.Slow(2);
            //collision.gameObject.GetComponent<CharacterControls>().StartCoroutine("stun");
        }


    }
}

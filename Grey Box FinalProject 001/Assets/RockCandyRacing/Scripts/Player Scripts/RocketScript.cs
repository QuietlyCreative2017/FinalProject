using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class RocketScript : MonoBehaviour {

    //XINPUT REQS
    PlayerIndex playerIndex;
    GamePadState currentState;
    GamePadState previousState;

    bool rocket = false;
    public GameObject rocketPrefab;
    Vector3 pos;
    bool shot = false;
    string type;

    private void Awake()
    {
        playerIndex = gameObject.GetComponent<CharacterControls>().GetPlayerIndex();
        type = gameObject.GetComponent<CharacterControls>().type;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentState = GamePad.GetState(playerIndex);

        pos = new Vector3(gameObject.transform.position.x + 2, gameObject.transform.position.y, gameObject.transform.position.z);
        if(currentState.Triggers.Right > 0 && rocket && !shot)
        {
            shot = true;
            rocket = false;
            Instantiate(rocketPrefab, pos, Quaternion.Euler(0, 0, 90));
        }
		//if(Input.GetAxis("Fire" + type) > 0 && rocket && !shot)
        //{
        //    shot = true;
        //    rocket = false;
        //    Instantiate(rocketPrefab, pos, Quaternion.Euler(0, 0, 90));
        //}

        previousState = currentState;
	}

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Rocket")
        {
            rocket = true;
            shot = false;
            Destroy(col.gameObject);
        }
    }
}

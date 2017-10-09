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
    bool canPickUp = true;

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

        pos = new Vector3(gameObject.transform.position.x + 5, gameObject.transform.position.y, gameObject.transform.position.z);
        if((currentState.Triggers.Right > 0 || currentState.Buttons.B == ButtonState.Pressed
              || currentState.Buttons.X == ButtonState.Pressed
               || currentState.Buttons.Y == ButtonState.Pressed) && rocket && !shot)
        {
            shot = true;
            rocket = false;
            Instantiate(rocketPrefab, pos, Quaternion.Euler(0, 0, 90));
            gameObject.GetComponent<DroppableScript>().enabled = true;
            canPickUp = true;
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
        if(col.gameObject.tag == "Rocket" && canPickUp && isActiveAndEnabled)
        {
            rocket = true;
            shot = false;
            Destroy(col.gameObject);
            gameObject.GetComponent<DroppableScript>().enabled = false;
            canPickUp = false;
        }
    }
}

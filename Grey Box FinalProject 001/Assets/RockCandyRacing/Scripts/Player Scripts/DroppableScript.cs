﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class DroppableScript : MonoBehaviour {

    //XINPUT REQS
    PlayerIndex playerIndex;
    GamePadState currentState;
    GamePadState previousState;

    public bool canUse = false;
    public GameObject droppableObject;
    public string type;
    bool canPickUp = true;
    float dirValue;

    private void Awake()
    {
        type = gameObject.GetComponent<CharacterControls>().type;
    }

    // Use this for initialization
    void Start () {
        playerIndex = gameObject.GetComponent<CharacterControls>().GetPlayerIndex();
    }
	
	// Update is called once per frame
	void Update () {
        currentState = GamePad.GetState(playerIndex);
        dirValue = Mathf.Sign(gameObject.GetComponent<CharacterControls>().fInput);
        //switch (type)
        //{
        //    case "WASD":
        //        if(Input.GetKeyDown(KeyCode.LeftAlt) && canUse)
        //        {
        //            Instantiate(droppableObject, new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
        //            canUse = false;
        //        }
        //        break;
        //    case "Key":
        //        if (Input.GetKeyDown(KeyCode.RightShift) && canUse)
        //        {
        //            Instantiate(droppableObject, new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
        //            canUse = false;
        //        }
        //        break;
        //}
        if((currentState.Triggers.Right > 0 || currentState.Buttons.B == ButtonState.Pressed
              || currentState.Buttons.X == ButtonState.Pressed
               || currentState.Buttons.Y == ButtonState.Pressed) && canUse)
        {
            canUse = false;
            Instantiate(droppableObject, gameObject.transform.position + Vector3.right * -dirValue * 2/*new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z)*/, new Quaternion(0, 0, 0, 0));
            gameObject.GetComponent<RocketScript>().enabled = true;
            canPickUp = true;
        }
	}

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Droppable" && canPickUp)
        {
            canUse = true;
            Destroy(collision.gameObject);
            gameObject.GetComponent<RocketScript>().enabled = false;
            canPickUp = false;
        }
    }
}

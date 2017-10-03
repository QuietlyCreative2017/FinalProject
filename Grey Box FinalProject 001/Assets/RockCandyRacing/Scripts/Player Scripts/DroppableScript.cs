using System.Collections;
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
        if((currentState.Buttons.Y == ButtonState.Pressed 
            || currentState.Buttons.B == ButtonState.Pressed
            || currentState.Buttons.X == ButtonState.Pressed) && canUse)
        {
            Instantiate(droppableObject, new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
            canUse = false;
        }
	}

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Droppable")
        {
            canUse = true;
            Destroy(collision.gameObject);
        }
    }
}

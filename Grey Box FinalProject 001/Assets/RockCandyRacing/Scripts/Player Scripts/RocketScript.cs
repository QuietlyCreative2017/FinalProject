using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class RocketScript : MonoBehaviour {

    //XINPUT REQS
    PlayerIndex playerIndex;
    GamePadState currentState;
    GamePadState previousState;

    public bool rocket = false;
    public GameObject rocketPrefab;
    Vector3 pos;
    public bool shot = false;
    public bool canPickUp = true;

    CharacterControls PlayerScript;
    public float PickupCD;

    public AudioManager AudManager;
    private void Awake()
    {
        playerIndex = gameObject.GetComponent<CharacterControls>().GetPlayerIndex();
        PlayerScript = gameObject.GetComponent<CharacterControls>();
        AudManager = GetComponent<AudioManager>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentState = GamePad.GetState(playerIndex);
        PickupCD = PlayerScript.PickupCDA; 

        //set spawn position
        pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        //input check
        if((currentState.Triggers.Right > 0 || currentState.Buttons.B == ButtonState.Pressed
              || currentState.Buttons.X == ButtonState.Pressed
               || currentState.Buttons.Y == ButtonState.Pressed) && rocket && !shot)
        {
            //shoot the thing
            shot = true;
            rocket = false;
            //AudManager.PlaySound("Rocket_launch_SFX_v3", false, 0.2f, 128);
            Instantiate(rocketPrefab, pos, Quaternion.Euler(0, 0, 0));
            gameObject.GetComponent<DroppableScript>().enabled = true;
            canPickUp = true;
            PlayerScript.PickupCDA = PlayerScript.PickupCD;
        }
        //set previous state to current
        previousState = currentState;
	}

    private void OnTriggerEnter(Collider col)
    {
        //check if you can pick up a thing
        if(col.gameObject.tag == "Rocket" && canPickUp && isActiveAndEnabled && PickupCD <= 0 && col.gameObject.GetComponent<PickUpBool>().Pickupable == true)
        {
            //pick up the thing
            AudManager.PlaySound("Rocket_Pickup_SFX", false, 0.2f, 128);
            rocket = true;
            shot = false;
            Destroy(col.gameObject);
            gameObject.GetComponent<DroppableScript>().enabled = false;
            canPickUp = false;
            col.gameObject.GetComponent<PickUpBool>().Pickupable = false;
        }
    }
}

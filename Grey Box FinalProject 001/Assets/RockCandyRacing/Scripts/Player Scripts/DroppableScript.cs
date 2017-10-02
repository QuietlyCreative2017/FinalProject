using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class DroppableScript : MonoBehaviour {

    public bool canUse = false;
    public GameObject droppableObject;
    public string type;

    private void Awake()
    {
        type = gameObject.GetComponent<CharacterControls>().type;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        switch (type)
        {
            case "WASD":
                if(Input.GetKeyDown(KeyCode.LeftAlt) && canUse)
                {
                    Instantiate(droppableObject, new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
                    canUse = false;
                }
                break;
            case "Key":
                if (Input.GetKeyDown(KeyCode.RightShift) && canUse)
                {
                    Instantiate(droppableObject, new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
                    canUse = false;
                }
                break;
        }
        if(XCI.GetButtonDown(XboxButton.RightBumper) && canUse)
        {
            Instantiate(droppableObject, new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
            canUse = false;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Droppable")
        {
            canUse = true;
            Destroy(collision.gameObject);
        }
    }
}

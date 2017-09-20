using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class DroppableScript : MonoBehaviour {

    public bool canUse = false;
    public GameObject droppableObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(XCI.GetButtonDown(XboxButton.RightBumper) && canUse)
        {
            Instantiate(droppableObject, new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
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

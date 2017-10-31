using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour {

    public GameObject Winner;
    bool won;
    public Animator anim;

	// Use this for initialization
	void Start () {
        won = false;
	}

    void OnTriggerExit(Collider collision)
    {
        //if a player enters set the winner
        if (collision.gameObject.tag == "Player")
        {
            Winner = collision.gameObject;
            won = true;
            anim.SetBool("HasWon", true);
        }
    }

        // Update is called once per frame
        void Update () {
		
	}

   public bool HasWon()
    {
        return won;
    }

    public GameObject ReturnWinner()
    {
        return Winner;
    }
}

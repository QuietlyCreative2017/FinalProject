using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour {

    public int StartLives;
    public int Currentlives;

	// Use this for initialization
	void Start () {
        Currentlives = StartLives;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RemoveLife()
    {
        Currentlives--;
    }

    public int Lives()
    {
        return Currentlives;
    }
}

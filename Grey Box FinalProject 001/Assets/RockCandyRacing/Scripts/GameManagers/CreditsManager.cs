using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour {

    public float CountDown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CountDown -= Time.deltaTime;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if(CountDown <= 0)
        {
            GoToMenu();
        }
	}

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main Menu");   
    }
}

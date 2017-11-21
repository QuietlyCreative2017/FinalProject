using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DistanceCloser : MonoBehaviour {

    public GameObject[] players;
    public float someDist;

    public float temp;
    public float tempLength;
    public float anotherTemp;

    public float loserSpeedIncrease;

    // Use this for initialization
    void Start () {
        players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        SortLeader();

        temp = players[1].transform.position.x - players[0].transform.position.x;
        //tempLength = Vector3.Magnitude(temp);
        anotherTemp = Mathf.Abs(temp);

        if(anotherTemp < someDist)
        {
            if(players[0].transform.position.x != players[1].transform.position.x)
            {
                CharacterControls conControls = players[0].GetComponent<CharacterControls>();
                conControls.loserSpeedIncrease = 1;
                //players[1].transform.Translate(new Vector3(1, 0, 0));
            }
        }
        else
        {
            CharacterControls conControls = players[0].GetComponent<CharacterControls>();
            conControls.loserSpeedIncrease = loserSpeedIncrease;
        }
	}

    public void SortLeader()
    {
        //sort the player array depending on x positions
        players = players.OrderBy(player => player.transform.position.x).ToArray();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CameraScript : MonoBehaviour
{
    public Camera cam;
    public GameObject[] players;
    GameObject leader;
    GameObject loser;
    public GameObject middle;

    public float screenPercent;
    float difference;


    Vector3 offset;
    float distanceX;
    public float zOffset;
    Vector3 velocity = Vector3.zero;

    float yCalc;

    public float maxZoom;
    public float minZoom;

    public float yOffset;
    private void Awake()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        cam = Camera.main;
    }

    // Use this for initialization
    void Start()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, -80);
    }

    void Update()
    {

    }

    void LateUpdate()
    {
        middle.transform.position = new Vector3(gameObject.transform.position.x, middle.transform.position.y, 1);
        SortLeader();
        if (players != null)
        {
            leader = players.Last();
            loser = players.First();

        }
        yCalc = 0;

        /////////////////////////gets the average y position of the players and sets the camera position to it/////////////////////////////////////
        //for each player
        for (int i = 0; i < players.Count(); i++)
        {
            //add current players y position to calc variable
            yCalc += players[i].transform.position.y;
        }
        //divide calc by number of players
        yCalc /= players.Count();
        //set camera position to the current position with average y position of players
        gameObject.transform.position = new Vector3(transform.position.x, yCalc + yOffset, transform.position.z);

        //Move to the right if the leading player is above screen percent
        if (Camera.main.WorldToViewportPoint(leader.transform.position).x >= screenPercent)
        {
            //only follow if the character is moving forward
            if (leader.GetComponent<CharacterControls>().fInput > 0)
            {
                gameObject.transform.position = new Vector3(leader.transform.position.x/* - difference*/, gameObject.transform.position.y/*gameObject.transform.position.y*/, gameObject.transform.position.z);
            }
        }


        //gets distance between leader and loser 
        distanceX = leader.transform.position.x - loser.transform.position.x;
        //if z position is within bounds, zoom in/out dependant on distance
        if (transform.position.z <= maxZoom && transform.position.z >= minZoom)
        {
            gameObject.transform.position = Vector3.SmoothDamp(transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, /*transform.position.z - */-distanceX * zOffset), ref velocity, 0.1f);

        }


        //camera z bounds
        if (transform.position.z > maxZoom)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, maxZoom);
        }
        if (transform.position.z < minZoom)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, minZoom);
        }

        
    }

    //not being used
    IEnumerator camWait(int a_index)
    {
        gameObject.transform.SetParent(players[a_index].transform);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.SetParent(null);
    }

    //sorts the player array by their x position
    public void SortLeader()
    {
        players = players.OrderBy(player => player.transform.position.x).ToArray();
    }
}

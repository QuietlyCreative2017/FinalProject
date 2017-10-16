using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CameraScript : MonoBehaviour
{
    public Camera cam;
    public List<GameObject> player;
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

    private void Awake()
    {
        player = new List<GameObject>(GameObject.FindGameObjectsWithTag("Player"));
        cam = Camera.main;
    }

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, -80);
    }

    void Update()
    {

    }

    void LateUpdate()
    {
        middle.transform.position = new Vector3(gameObject.transform.position.x, middle.transform.position.y, 1);
        SortLeader();
        leader = player.Last();
        loser = player.First();
        yCalc = 0;

        /////////////////////////gets the average y position of the players and sets the camera position to it/////////////////////////////////////
        //for each player
        for (int i = 0; i < player.Count; i++)
        {
            //add current players y position to calc variable
            yCalc += player[i].transform.position.y;
        }
        //divide calc by number of players
        yCalc /= player.Count;
        //set camera position to the current position with average y position of players
        transform.position = new Vector3(transform.position.x, yCalc, transform.position.z);
        
        //Move to the right if the leading player is above screen percent
        if (Camera.main.WorldToViewportPoint(leader.transform.position).x >= screenPercent)
        {
            //if (!distSet)
            //{
            //    difference = Vector3.Distance(new Vector3(leader.transform.position.x, 0, 0), new Vector3(middle.transform.position.x, 0, 0));
            //    distSet = true;
            //}

            //only follow if the character is moving forward
            if (leader.GetComponent<CharacterControls>().fInput > 0)
            {
                gameObject.transform.position = new Vector3(leader.transform.position.x/* - difference*/, gameObject.transform.position.y/*gameObject.transform.position.y*/, gameObject.transform.position.z);
            }
        }
        
        //gets distance between leader and loser
        //distanceX = leader.transform.position.x - loser.transform.position.x;

        //if z position is within bounds, zoom in/out dependant on distance
        if (transform.position.z >= -150 && transform.position.z <= -65)
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, transform.position.y, /*transform.position.z - */-distanceX * 4 + zOffset), ref velocity, 0.02f);

        
        //camera z bounds
        if (transform.position.z < -150)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -150);
        }
        if (transform.position.z > -65)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -65);
        }

        //zoom in
        //if ((loseX >= 0.4 && leadX >= 0.4) && cam.transform.position.z < -45)
        //{
        //    if(leadX >= screenPercent)
        //    {
        //        cam.transform.position = Vector3.SmoothDamp(gameObject.transform.position, new Vector3(leader.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), ref velocity, 0.3f);
        //    }
        //    cam.transform.Translate(new Vector3(0, 0, 1));
        //    distSet = false;
        //}


        //for (int i = 0; i < player.Count; i++)
        //{
        //   // pos[i] = Camera.main.WorldToViewportPoint(player[i].transform.position);
        //   //
        //   // if (pos[i].x >= masd)
        //   // {
        //   //     if (!distSet)
        //   //     {
        //   //         difference = leader.transform.position.x - middle.transform.position.x;
        //   //         distSet = true;
        //   //     }
        //   //     if (player[i].GetComponent<CharacterControls>().h > 0)
        //   //     {
        //   //         gameObject.transform.position = new Vector3(leader.transform.position.x - difference, gameObject.transform.position.y, gameObject.transform.position.z);
        //   //         //gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, new Vector3(leader.transform.position.x - difference, gameObject.transform.position.y, gameObject.transform.position.z), ref Velocity, 0);
        //   //
        //   //     }
        //   // }
        //    if (pos[i].x <= 0.1 && cam.transform.position.z >= -80)
        //    {
        //        cam.transform.Translate(new Vector3(0, 0, -1));
        //        //difference = leader.transform.position.x - middle.transform.position.x;
        //        //distSet = false;
        //    }
        //
        //}
        //if (pos[0].x >= 0.4 && pos[1].x >= 0.4 && cam.transform.position.z < -50)
        //{
        //    //gameObject.transform.position = new Vector3(leader.transform.position.x - difference, gameObject.transform.position.y, gameObject.transform.position.z);
        //    //difference = leader.transform.position.x - middle.transform.position.x;
        //    cam.transform.Translate(new Vector3(0, 0, 1));
        //    //distSet = false;
        //}
    }

    //not being used
    IEnumerator camWait(int a_index)
    {
        gameObject.transform.SetParent(player[a_index].transform);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.SetParent(null);
    }

    //sorts the player array by their x position
    public void SortLeader()
    {
        player = player.OrderBy(player => player.transform.position.x).ToList();
    }

    //public GameObject Loser()
    //{
    //    retur
    //}
}

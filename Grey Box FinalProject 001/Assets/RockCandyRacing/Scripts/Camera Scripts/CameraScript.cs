using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CameraScript : MonoBehaviour
{
    public Camera cam;
    Vector3[] pos;
    public List<GameObject> player;
    GameObject leader;
    GameObject loser;
    public GameObject middle;
    bool distSet = false;

    public float screenPercent;
    float difference;

    float leadX;
    float loseX;

    Vector3 offset;

    Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        player = new List<GameObject>(GameObject.FindGameObjectsWithTag("Player"));
        cam = Camera.main;
    }

    // Use this for initialization
    void Start()
    {
        pos = new[] { new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f) };
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
        leadX = Camera.main.WorldToViewportPoint(leader.transform.position).x;
        loseX = Camera.main.WorldToViewportPoint(loser.transform.position).x;

        //transform.position = new Vector3(transform.position.x, leader.transform.position.y + offset.y, transform.position.z);

        //if (Camera.main.WorldToViewportPoint(leader.transform.position).y >= screenPercent || Camera.main.WorldToViewportPoint(leader.transform.position).y <= 0.1f)
        //{
        //    if(!yChanged)
        //    {
        //        yDifference = leader.transform.position.y - middle.transform.position.y;
        //        yChanged = true;
        //    }
        //
        //    cam.transform.position = new Vector3(gameObject.transform.position.x, leader.transform.position.y - yDifference, gameObject.transform.position.z);
        //}

        if (Camera.main.WorldToViewportPoint(leader.transform.position).x >= screenPercent)
        {
            if (!distSet)
            {
                difference = Vector3.Distance(new Vector3(leader.transform.position.x, 0, 0), new Vector3(middle.transform.position.x, 0, 0));
                distSet = true;
            }

            if (leader.GetComponent<CharacterControls>().h > 0)
            {
                gameObject.transform.position = new Vector3(leader.transform.position.x/* - difference*/, gameObject.transform.position.y/*gameObject.transform.position.y*/, gameObject.transform.position.z);
                //gameObject.transform.SetParent(leader.transform);
            }
        }
        else
        {
            gameObject.transform.SetParent(null);
        }

        //zoom out
        if (Camera.main.WorldToViewportPoint(loser.transform.position).x <= 0.1 && cam.transform.position.z >= -150)
        {
            
            cam.transform.position = Vector3.SmoothDamp(cam.transform.position, new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z - 1), ref velocity, 0.001f);
            //cam.transform.Translate(new Vector3(0, 0, -1));
            distSet = false;
        }

        //zoom in
        if ((loseX >= 0.4 && leadX >= 0.4) && cam.transform.position.z < -145)
        {
            if(leadX >= screenPercent)
            {
                cam.transform.position = Vector3.SmoothDamp(gameObject.transform.position, new Vector3(leader.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), ref velocity, 0.3f);
            }
            cam.transform.Translate(new Vector3(0, 0, 1));
            distSet = false;
        }
        //    for (int i = 0; i < player.Count; i++)
        //    {
        //        pos[i] = Camera.main.WorldToViewportPoint(player[i].transform.position);
        //
        //        if (pos[i].x >= masd)
        //        {
        //            if (!distSet)
        //            {
        //                difference = leader.transform.position.x - middle.transform.position.x;
        //                distSet = true;
        //            }
        //            if (player[i].GetComponent<CharacterControls>().h > 0)
        //            {
        //                gameObject.transform.position = new Vector3(leader.transform.position.x - difference, gameObject.transform.position.y, gameObject.transform.position.z);
        //                //gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, new Vector3(leader.transform.position.x - difference, gameObject.transform.position.y, gameObject.transform.position.z), ref Velocity, 0);
        //
        //            }
        //        }
        //    //    if (pos[i].x <= 0.1 && cam.transform.position.z >= -80)
        //    //    {
        //    //        cam.transform.Translate(new Vector3(0, 0, -1));
        //    //        difference = leader.transform.position.x - middle.transform.position.x;
        //    //        distSet = false;
        //    //    }
        //
        //    }
        //   // if (pos[0].x >= 0.4 && pos[1].x >= 0.4 && cam.transform.position.z < -50)
        //   // {
        //   //     gameObject.transform.position = new Vector3(leader.transform.position.x - difference, gameObject.transform.position.y, gameObject.transform.position.z);
        //   //     difference = leader.transform.position.x - middle.transform.position.x;
        //   //     cam.transform.Translate(new Vector3(0, 0, 1));
        //   //     distSet = false;
        //   // }
    }

    IEnumerator camWait(int a_index)
    {
        gameObject.transform.SetParent(player[a_index].transform);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.SetParent(null);
    }

    public void SortLeader()
    {
        player = player.OrderBy(player => player.transform.position.x).ToList();
    }

    //public GameObject Loser()
    //{
    //    retur
    //}
}

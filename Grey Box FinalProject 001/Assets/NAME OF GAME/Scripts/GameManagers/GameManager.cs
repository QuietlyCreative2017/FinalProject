using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;
using System.Linq;

public class GameManager : MonoBehaviour
{

    public GameObject[] Checkpoints;
    GameObject[] ToggledCheckpoints;
    GameObject[] player;
    GameObject leader;
    Vector3 camView;

    // Use this for initialization
    void Awake()
    {
        Checkpoints = GameObject.FindGameObjectsWithTag("Checkpoints");
        player = GameObject.FindGameObjectsWithTag("Player");
    }

    private void Start()
    {
        InvokeRepeating("OrderCheckpoints", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Checkpoints = Checkpoints.OrderBy(Checkpoints => Checkpoints.GetComponent<CheckpointScript>().toggled).ToArray();

        for (int i = 0; i < 2; i++)
        {
            leader = SortDistance();
            if (Camera.main.WorldToViewportPoint(player[i].transform.position).y <= 0 || Camera.main.WorldToViewportPoint(player[i].transform.position).x <= 0)
            {
                //Vector3 newT = Checkpoints.transform.position;
                //newT.Set(Checkpoints.transform.position.x, Checkpoints.transform.position.y + 10, 0);
                Vector3 newT = Checkpoints[Checkpoints.Length - 1].transform.position;
                newT.Set(newT.x, newT.y, 1);
                player[i].transform.position = newT;
            }

        }
    }

    public GameObject SortDistance()
    {
        if (player[0].transform.position.x > player[1].transform.position.x)
        {
            return player[0];
        }
        else return player[1];
    }

    void OrderCheckpoints()
    {
        Checkpoints = Checkpoints.OrderBy(Checkpoints => Checkpoints.transform.position.x).ToArray();
    }
}

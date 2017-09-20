using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameObject Checkpoints;
    GameObject[] player;
    GameObject leader;

    // Use this for initialization
    void Awake()
    {
        Checkpoints = GameObject.FindGameObjectWithTag("Checkpoints");
        player = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 2; i++)
        {
            leader = SortDistance();
            if (Camera.main.WorldToViewportPoint(player[i].transform.position).y <= 0 || Camera.main.WorldToViewportPoint(player[i].transform.position).x <= 0)
            {
                //Vector3 newT = Checkpoints.transform.position;
                //newT.Set(Checkpoints.transform.position.x, Checkpoints.transform.position.y + 10, 0);
                Vector3 newT = leader.transform.position;
                newT.Set(newT.x, newT.y + 10, newT.z);
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameObject Checkpoints;
    GameObject[] player;

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
            if (Camera.main.WorldToViewportPoint(player[i].transform.position).y <= 0 || Camera.main.WorldToViewportPoint(player[i].transform.position).x <= 0)
            {
                Vector3 newT = Checkpoints.transform.position;
                newT.Set(Checkpoints.transform.position.x, Checkpoints.transform.position.y + 10, 0);
                player[i].transform.position = newT;
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera cam;
    Vector3[] pos;
    GameObject[] player;
    public Vector3 translate = new Vector3(1, 0, 0);
    public float transSpeed;
    public float fovSpeed;

    private void Awake()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        cam = Camera.main;
        translate *= transSpeed * Time.deltaTime;
    }

    // Use this for initialization
    void Start()
    {
        pos = new[] { new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f) };
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 2; i++)
        {
            pos[i] = Camera.main.WorldToViewportPoint(player[i].transform.position);
            //translate *= transSpeed * Time.deltaTime;

            if (pos[i].x >= 0.5f)
            {
                transform.Translate(translate);
            }
            if (pos[i].x <= 0.1 && cam.orthographicSize <= 25)
            {
                cam.orthographicSize += fovSpeed;
            }
           
        }
        if (pos[0].x >= 0.4 && pos[1].x >= 0.4 && cam.orthographicSize >= 15)
        {
            cam.orthographicSize -= 1f;
        }
    }
}

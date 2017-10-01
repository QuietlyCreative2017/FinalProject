using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera cam;
    Vector3[] pos;
    GameObject[] player;
    public Vector3 translate = new Vector3(1, 0, 0);
    public float fovSpeed;
    Rigidbody rb;
    GameObject leader;

    private void Awake()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        cam = Camera.main;
    }

    // Use this for initialization
    void Start()
    {
        pos = new[] { new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f) };
        
    }

    void Update()
    {
        gameObject.transform.parent = null;
        leader = SortDistance();
        Debug.Log(SortDistance().name);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        for (int i = 0; i < 2; i++)
        {
            pos[i] = Camera.main.WorldToViewportPoint(player[i].transform.position);

            if (pos[i].x >= 0.5f)
            {
                //if (player[i].GetComponent<Rigidbody>().velocity.x > 0 && player[i].GetComponent<Rigidbody>().velocity.x <= 12)
                //{
                //    gameObject.transform.position = new Vector3(leader.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                //}
                gameObject.transform.Translate(translate);
            }
            if (pos[i].x <= 0.1 && cam.transform.position.z >= -80)
            {
                cam.transform.Translate(new Vector3(0, 0, -1));
            }
           
        }
        if (pos[0].x >= 0.4 && pos[1].x >= 0.4 && cam.transform.position.z < -50)
        {
            cam.transform.Translate(new Vector3(0, 0, 1));
        }
    }

    IEnumerator camWait(int a_index)
    {
        gameObject.transform.SetParent(player[a_index].transform);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.SetParent(null);
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

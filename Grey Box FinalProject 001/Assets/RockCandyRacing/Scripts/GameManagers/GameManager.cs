using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;
using System.Linq;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] Checkpoints;
    GameObject[] ToggledCheckpoints;
    GameObject[] player;
    GameObject leader;
    Vector3 camView;
    public GameObject SpawnPoint;
    Vector3 newT;
    public GameObject WinTextObj;
    public GameObject WinObj;
    GameObject P2health;
    GameObject P1health;
    public GameObject DeathTouch;

    public AudioSource[] audSources;

    float deltaTime = 0.0f;
    // Use this for initialization
    void Awake()
    {
        audSources = GetComponents<AudioSource>();
        Checkpoints = GameObject.FindGameObjectsWithTag("Checkpoints");
        player = GameObject.FindGameObjectsWithTag("Player");
        P2health = GameObject.Find("P1Health");
        P1health = GameObject.Find("P2Health");
    }

    private void Start()
    {
        InvokeRepeating("OrderCheckpoints", 1f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        //Checkpoints = Checkpoints.OrderBy(Checkpoints => Checkpoints.GetComponent<CheckpointScript>().toggled).ToArray();
        //CheckGameOver();
        P1health.GetComponent<Text>().text = player[0].GetComponent<PlayerLives>().Lives().ToString();
        P2health.GetComponent<Text>().text = player[1].GetComponent<PlayerLives>().Lives().ToString();
        for (int i = 0; i < player.Length; i++)
        {
            leader = SortDistance();
            if (Camera.main.WorldToViewportPoint(player[i].transform.position).y <= 0 || Camera.main.WorldToViewportPoint(player[i].transform.position).x <= 0)
            {
                newT.Set(SpawnPoint.transform.position.x, 10, 1);
                player[i].transform.position = newT;
                player[i].GetComponent<PlayerLives>().RemoveLife();
                player[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if(player[i].transform.position.y <= DeathTouch.transform.position.y)
            {
                newT.Set(SpawnPoint.transform.position.x, 10, 1);
                player[i].transform.position = newT;
                player[i].GetComponent<PlayerLives>().RemoveLife();
                player[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            }

        }
    }

    private void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 15, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
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

    bool CheckGameOver()
    {
        if(WinObj.GetComponent<WinBox>().HasWon())
        {
            Time.timeScale = 0;
            WinTextObj.SetActive(true);
            WinTextObj.GetComponent<Text>().text = /*"Player " +*/ WinObj.GetComponent<WinBox>().Winner.name + " has won";
            return true;
        }
        for(int i = 0; i < player.Length; i++)
        {
            if (player[i].GetComponent<PlayerLives>().Lives() == 0)
            {
                Time.timeScale = 0;
                WinTextObj.SetActive(true);
                WinTextObj.GetComponent<Text>().text = "Player " + i + " lost because he died too much";
                return true;
            }
        }

        return false;
    }
}

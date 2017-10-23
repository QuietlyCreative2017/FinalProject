using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject[] Checkpoints;
    GameObject[] ToggledCheckpoints;
    GameObject[] player;
    Vector3 camView;
    public GameObject SpawnPoint;
    Vector3 newT;
    public GameObject WinTextObj;
    public GameObject WinObj;
    GameObject P2health;
    GameObject P1health;
    public GameObject DeathTouch;
    float deltaTime = 0.0f;

    public AudioSource m_asMainSource;
    public AudioClip[] m_acAudClips;

    public float countDownTimer;
    // Use this for initialization
    void Awake()
    {
        Checkpoints = GameObject.FindGameObjectsWithTag("Checkpoints");
        player = GameObject.FindGameObjectsWithTag("Player");
        P2health = GameObject.Find("P1Health");
        P1health = GameObject.Find("P2Health");
    }

    private void Start()
    {
        StartCoroutine("CountDown");
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
       //if(CheckGameOver())
       //{
       //    SceneManager.LoadScene(0);
       //}
        //CheckGameOver();
        P1health.GetComponent<Text>().text = player[0].GetComponent<PlayerLives>().Lives().ToString();
        P2health.GetComponent<Text>().text = player[1].GetComponent<PlayerLives>().Lives().ToString();

        SortLeader();

        for (int i = 0; i < player.Length; i++)
        {
            //if a player has fallen to the left of the screen
            if (Camera.main.WorldToViewportPoint(player[i].transform.position).x <= 0)
            {
                //respawn them
                Vector3 disPos = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)); 
                newT.Set(SpawnPoint.transform.position.x, disPos.y, 1);
                player[i].transform.position = newT;
                player[i].GetComponent<PlayerLives>().RemoveLife();
                player[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                player[i].GetComponent<CharacterControls>().Respawn();
            }
            //if a player has touched a death box thing
            if(player[i].transform.position.y <= DeathTouch.transform.position.y)
            {
                //respawn them
                newT.Set(SpawnPoint.transform.position.x, 25, 1);
                player[i].transform.position = newT;
                player[i].GetComponent<PlayerLives>().RemoveLife();
                player[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                player[i].GetComponent<CharacterControls>().Respawn();
            }

        }
    }

    private void OnGUI()
    {
        //all of this is the fps counter

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

    void OrderCheckpoints()
    {
        //order the non-existant checkpoints by x position
        Checkpoints = Checkpoints.OrderBy(Checkpoints => Checkpoints.transform.position.x).ToArray();
    }

    bool CheckGameOver()
    {
        //check if a player has hit the end
        if(WinObj.GetComponent<WinBox>().HasWon())
        {
            //Time.timeScale = 0;
            WinTextObj.SetActive(true);
            WinTextObj.GetComponent<Text>().text = /*"Player " +*/ WinObj.GetComponent<WinBox>().Winner.name + " has won";
            return true;
        }
        for(int i = 0; i < player.Length; i++)
        {
            //see if a player has run out of lives
            if (player[i].GetComponent<PlayerLives>().Lives() == 0)
            {
                //Time.timeScale = 0;
                WinTextObj.SetActive(true);
                WinTextObj.GetComponent<Text>().text = "Player " + i + " lost because he died too much";
                return true;
            }
        }

        return false;
    }

    public void SortLeader()
    {
        //sort the player array depending on x positions
        player = player.OrderBy(player => player.transform.position.x).ToArray();
    }


    
    IEnumerator CountDown()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(countDownTimer);
        Time.timeScale = 1;
    }
}

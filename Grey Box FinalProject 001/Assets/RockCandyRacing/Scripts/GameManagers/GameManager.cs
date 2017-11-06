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
    GameObject[] PlayerHealth;
    public GameObject DeathTouch;
    float deltaTime = 0.0f;

    public AudioSource m_asMainSource;
    public AudioClip[] m_acAudClips;

    public float countDownTimer;

    GameObject winner;
    Camera mainCamera;

    public float EndGameYOffset;

    public bool CheckingGameOver;

    public string[] EndBossCode;
    public int CodeIndex;

    public GameObject EndGameUI;
    public GameObject InGameUI;
    public Text endGameText;

    enum GameState
    {
        Playing,
        GameOver,
    }

    GameState CurrentState;

    // Use this for initialization
    void Awake()
    {
        Checkpoints = GameObject.FindGameObjectsWithTag("Checkpoints");
        player = GameObject.FindGameObjectsWithTag("Player");
        PlayerHealth = GameObject.FindGameObjectsWithTag("PlayerHealth");
        mainCamera = Camera.main;
        EndGameUI.SetActive(false);
    }

    private void Start()
    {
        WinTextObj.SetActive(false);
        StartCoroutine("CountDown");
        Cursor.visible = false;
        CurrentState = GameState.Playing;
        InGameUI.SetActive(true);

        CodeIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (CurrentState)
        {
            ////////////////////////////////////////Start Playing State//////////////////////////////////////////////////////////
            case GameState.Playing:
                EndGameUI.SetActive(false);
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }
                deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
                if (CheckingGameOver)
                {
                    winner = CheckGameOver();

                }

                if (Input.anyKeyDown)
                {
                    // Check if the next key in the code is pressed
                    if (Input.GetKeyDown(EndBossCode[CodeIndex]))
                    {
                        // Add 1 to index to check the next key in the code
                        CodeIndex++;
                    }
                    // if wrong key is entered, reset the code
                    else
                    {
                        CodeIndex = 0;
                    }
                }
                // If index reaches the length of the cheatCode string, 
                // the entire code was correctly entered
               // if (CodeIndex == EndBossCode.Length)
               // {
               //     //returns the index to 0 and loads the fps scene
               //     CodeIndex = 0;
               //     SceneManager.LoadScene(2);
               // }

               

                SortLeader();

                for (int i = 0; i < player.Length; i++)
                {
                    //if a player has fallen to the left of the screen
                    if (mainCamera.WorldToViewportPoint(player[i].transform.position).x <= 0)
                    {
                        //respawn them
                        Vector3 disPos = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
                        newT.Set(SpawnPoint.transform.position.x, disPos.y, -1);
                        player[i].transform.position = newT;
                        player[i].GetComponent<PlayerLives>().RemoveLife();
                        player[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                        player[i].GetComponent<CharacterControls>().Respawn();
                    }
                    //if a player has touched a death box thing
                    if (player[i].transform.position.y <= DeathTouch.transform.position.y)
                    {
                        //respawn them
                        newT.Set(SpawnPoint.transform.position.x, 25, -1);
                        player[i].transform.position = newT;
                        player[i].GetComponent<PlayerLives>().RemoveLife();
                        player[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                        player[i].GetComponent<CharacterControls>().Respawn();
                    }

                }
                break;
            ////////////////////////////////////////End Playing State//////////////////////////////////////////////////////////

            ////////////////////////////////////////Start Game Over State//////////////////////////////////////////////////////////
            case GameState.GameOver:
                
                StartCoroutine("EndGameCountdown");
                //winner.gameObject.GetComponent<CharacterControls>().PlayWinAnimation();
                winner.gameObject.GetComponent<CharacterControls>().enabled = false;
                winner.gameObject.GetComponent<CharacterControls>().winAnim.SetBool("HasWon", true);
                mainCamera.GetComponent<CameraScript>().enabled = false;
                WinTextObj.SetActive(true);
                WinTextObj.GetComponent<Text>().text = winner.name + " won";
                mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(winner.transform.position.x, winner.transform.position.y + EndGameYOffset, -40), 0.01f);
                break;
                ////////////////////////////////////////End Game Over State//////////////////////////////////////////////////////////////
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

    GameObject CheckGameOver()
    {
        //check if a player has hit the end
        if (WinObj.GetComponent<WinBox>().HasWon())
        {
            //set current state to gameover
            CurrentState = GameState.GameOver;
            //return whomever reached the end point
            return WinObj.GetComponent<WinBox>().Winner;
        }
        for (int i = 0; i < player.Length; i++)
        {
            //see if a player has run out of lives
            if (player[i].GetComponent<PlayerLives>().Lives() <= 0)
            {
                //Deactivate dead player
                player[i].SetActive(false);
                //Set current state to GameOver
                CurrentState = GameState.GameOver;
                //Go through player array and return first player who is still alive
                for (int j = 0; j < player.Length; j++)
                {
                    if (player[j].GetComponent<PlayerLives>().Lives() > 0)
                    {
                        return player[j];
                    }
                }
            }
        }

        //else return null
        return null;
    }

    public void SortLeader()
    {
        //sort the player array depending on x positions
        player = player.OrderBy(player => player.transform.position.x).ToArray();
    }



    IEnumerator CountDown()
    {
        Time.timeScale = 0;
        WinTextObj.SetActive(true);
        for (float i = countDownTimer; i >= 0; i--)
        {
            yield return new WaitForSecondsRealtime(1);
            WinTextObj.GetComponent<Text>().text = i.ToString();
        }
        WinTextObj.SetActive(false);
        Time.timeScale = 1;
    }


    IEnumerator EndGameCountdown()
    {
        Time.timeScale = 0f;
        endGameText.text = winner.name + " won";
        //text1.text = winner.name + " won";
        for (float i = countDownTimer; i >= 0; i--)
        {
            yield return new WaitForSecondsRealtime(1);
        }
        InGameUI.SetActive(false);

        EndGameUI.SetActive(true);
        for (float j = countDownTimer; j >= 0; j--)
        {
            endGameText.text = "Begining in " + j;
            yield return new WaitForSecondsRealtime(1);
        }
        

        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Playground_V02");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;
using XInputDotNetPure;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{

    public GameObject[] Checkpoints;
    GameObject[] ToggledCheckpoints;

    public GameObject[] player;
    Vector3 camView;
    public GameObject SpawnPoint;
    Vector3 newT;
    public GameObject WinTextObj;
    public GameObject WinObj;
    public GameObject DeathTouch;

    public AudioSource m_asMainSource;
    public AudioClip[] m_acAudClips;

    public float countDownTimer;

    GameObject winner;
    Camera mainCamera;

    public float EndGameYOffset;

    public bool CheckingGameOver;

    public GameObject EndGameUI;
    public GameObject InGameUI;
    public Text endGameText;

    public EventSystem m_ESystem;
    public Button m_BFirstButton;


    public AudioManager audManager;

    public GameObject[] CountDownUIPics;

    public GameObject[] EndGameUIPics;

    public GameObject[] PlayerUI;

    Button[] menuButtons;
    GameObject previousSelected;

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
        mainCamera = Camera.main;
        audManager = GetComponent<AudioManager>();
        EndGameUI.SetActive(false);
        menuButtons = GameObject.FindObjectsOfType<Button>();
    }

    private void Start()
    {
        WinTextObj.SetActive(false);
        StartCoroutine("NewCountdown");
        Cursor.visible = false;
        CurrentState = GameState.Playing;
        InGameUI.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        menuButtons = GameObject.FindObjectsOfType<Button>();
        if (m_ESystem.currentSelectedGameObject != previousSelected)
        {
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].transform.localScale = new Vector3(1, 1, 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        switch (CurrentState)
        {
            ////////////////////////////////////////Start Playing State//////////////////////////////////////////////////////////
            case GameState.Playing:
                EndGameUI.SetActive(false);

                if (CheckingGameOver)
                {
                    winner = CheckGameOver();
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    CameraScript camScript = mainCamera.GetComponent<CameraScript>();
                    camScript.StartCoroutine(camScript.ScreenShake(1, 5, 1));
                }


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
                        audManager.PlaySound("Cat_Death_SFX", false, 0.2f, 128);
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
                //StartCoroutine("NewEndGameCountdown");
                stopVibration();
                //winner.gameObject.GetComponent<CharacterControls>().PlayWinAnimation();
                if (winner != null)
                {

                    winner.gameObject.GetComponent<CharacterControls>().enabled = false;
                    winner.gameObject.GetComponent<CharacterControls>().winAnim.SetBool("HasWon", true);

                    if (winner.name == "Player1")
                    {
                        PlayerUI[1].SetActive(false);
                    }
                    else
                    {
                        PlayerUI[0].SetActive(false);
                    }
                }
                else
                {
                    for (int i = 0; i < PlayerUI.Length; i++)
                    {
                        PlayerUI[i].SetActive(false);
                    }
                }
                mainCamera.GetComponent<CameraScript>().enabled = false;
                if (winner != null)
                    mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(winner.transform.position.x, winner.transform.position.y + EndGameYOffset, -40), 0.01f);
                break;
                ////////////////////////////////////////End Game Over State//////////////////////////////////////////////////////////////
        }


                previousSelected = m_ESystem.currentSelectedGameObject;
    }

    private void OnGUI()
    {

    }

    void OrderCheckpoints()
    {
        //order the non-existant checkpoints by x position
        Checkpoints = Checkpoints.OrderBy(Checkpoints => Checkpoints.transform.position.x).ToArray();
    }

    GameObject CheckGameOver()
    {
        float deathCount = 0;
        //check if a player has hit the end
        if (WinObj.GetComponent<WinBox>().HasWon())
        {
            //set current state to gameover
            CurrentState = GameState.GameOver;
            //return whomever reached the end point
            audManager.PlaySound("Studio crowd celebration cheer clap_BLASTWAVEFX_12945", false, 0.2f, 128);
            StartCoroutine(NewEndGameCountdown(WinObj.GetComponent<WinBox>().Winner));
            return WinObj.GetComponent<WinBox>().Winner;
        }
        for (int i = 0; i < player.Length; i++)
        {
            //see if a player has run out of lives
            if (player[i].GetComponent<PlayerLives>().Lives() <= 0)
            {
                deathCount++;
                //Deactivate dead player
                player[i].SetActive(false);
                //Set current state to GameOver
                CurrentState = GameState.GameOver;
                //Go through player array and return first player who is still alive
                for (int j = 0; j < player.Length; j++)
                {
                    if (player[j].GetComponent<PlayerLives>().Lives() > 0)
                    {
                        StartCoroutine(NewEndGameCountdown(player[j]));
                        return player[j];
                    }
                }
            }
        }

        if (deathCount == player.Length)
        {
            StartCoroutine(NewEndGameCountdown(null));
            return null;
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

        //do a countdown for countDownTimer seconds
        for (float i = countDownTimer; i >= 0; i--)
        {
            yield return new WaitForSecondsRealtime(1);
            //display countdown timer
            WinTextObj.GetComponent<Text>().text = i.ToString();
        }
        WinTextObj.SetActive(false);
        Time.timeScale = 1;
    }


    IEnumerator EndGameCountdown()
    {
        //set timescale to zero
        Time.timeScale = 0f;

        //do a countdown for however many seconds to let animation play
        for (float i = countDownTimer; i >= 0; i--)
        {
            yield return new WaitForSecondsRealtime(1);
        }
        //disable ingameui
        InGameUI.SetActive(false);

        //enable endgameui
        EndGameUI.SetActive(true);

        //do another countdown for however many seconds
        for (float j = countDownTimer; j >= 0; j--)
        {
            endGameText.text = "Beginning in " + j;
            yield return new WaitForSecondsRealtime(1);
        }

        //set timescale to 1
        Time.timeScale = 1;
        //load play scene again
        SceneManager.LoadScene(1);
    }

    public void goToMenu()
    {
        audManager.PlaySound("Nav_Menu_SFX", false, 0.2f, 128);
        StartCoroutine(WaitForSecondsThenLoadScene(0, "Main Menu"));
    }

    public void Restart()
    {
        audManager.PlaySound("Nav_Menu_SFX", false, 0.2f, 128);
        StartCoroutine(WaitForSecondsThenLoadScene(0, "Playground_V03"));
    }


    void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            StartCoroutine("SetSelectedGameobject");
        }
        if (!focus)
        {
            stopVibration();
        }
    }

    IEnumerator SetSelectedGameobject()
    {
        m_ESystem.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        m_ESystem.SetSelectedGameObject(m_BFirstButton.gameObject);
    }


    IEnumerator WaitForSecondsThenLoadScene(int seconds, string sceneName)
    {
        yield return new WaitForSecondsRealtime(seconds);
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator NewCountdown()
    {
        Time.timeScale = 0;
        for (int i = 0; i < 3; i++)
        {
            CountDownUIPics[i].SetActive(true);
            audManager.PlaySound("Timer_Beep_" + (3 - i), false, 0.2f, 128);
            yield return new WaitForSecondsRealtime(1);
            CountDownUIPics[i].SetActive(false);
        }
        Time.timeScale = 1;
        for (int i = 0; i < player.Length; i++)
        {
            player[i].GetComponent<CharacterControls>().RefreshInputState();
        }
    }

    IEnumerator NewEndGameCountdown(GameObject winner)
    {
        //set timescale to zero
        this.winner = winner;
        Time.timeScale = 0f;
        if (winner != null)
        {

            WinTextObj.SetActive(true);

            yield return new WaitForSecondsRealtime(1);
            audManager.PlaySound("Studio crowd celebration cheer clap_BLASTWAVEFX_12945", false, 0.2f, 128);
            //do a countdown for however many seconds to let animation play
            for (float i = countDownTimer; i >= 0; i--)
            {
                yield return new WaitForSecondsRealtime(1);
            }

            //enable endgameui
            WinTextObj.SetActive(false);

        }
        EndGameUI.SetActive(true);

        m_ESystem.SetSelectedGameObject(m_BFirstButton.gameObject);

        for (int i = 0; i < 3; i++)
        {
            EndGameUIPics[i].SetActive(true);
            yield return new WaitForSecondsRealtime(1);
            EndGameUIPics[i].SetActive(false);
        }

        //set timescale to 1
        Time.timeScale = 1;
        //load play scene again
        SceneManager.LoadScene(1);
    }

    void stopVibration()
    {
        GamePad.SetVibration(PlayerIndex.One, 0, 0);
        GamePad.SetVibration(PlayerIndex.Two, 0, 0);
    }

    public int returnIndex(string a_playerName)
    {
        for (int i = 0; i < player.Length; i++)
        {
            if (player[i].name == a_playerName)
            {
                return i;
            }
        }
        return int.MaxValue;
    }
}

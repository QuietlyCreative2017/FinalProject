using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using XInputDotNetPure;
using XboxCtrlrInput;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour {

    public GameObject LoadScreen;
    public Slider slider;

    public EventSystem m_ESystem;
    public Button m_BFirstButton;

    public AudioManager audManager;

    void Awake()
    {
        audManager = GetComponent<AudioManager>();
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame()
    {
        StartCoroutine("LoadASynchronously");
    }

    public void Credits()
    {
        audManager.PlaySound("Nav_Menu_SFX", false, 0.2f, 128);
    }

    public void Exit()
    {
        audManager.PlaySound("Nav_Menu_SFX", false, 0.2f, 128);
        Application.Quit();
    }

    IEnumerator LoadASynchronously()
    {

        audManager.PlaySound("Menu_Select_SFX", false, 0.2f, 128);
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        LoadScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
    }

    void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            StartCoroutine("SetSelectedGameobject");
        }
    }


    IEnumerator SetSelectedGameobject()
    {
        m_ESystem.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        m_ESystem.SetSelectedGameObject(m_BFirstButton.gameObject);
    }
}

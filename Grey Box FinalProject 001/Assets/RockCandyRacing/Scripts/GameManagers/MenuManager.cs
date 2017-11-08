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

    }

    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator LoadASynchronously()
    {
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

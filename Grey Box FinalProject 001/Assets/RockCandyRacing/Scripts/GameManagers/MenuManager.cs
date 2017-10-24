using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    public GameObject LoadScreen;
    public Slider slider;

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
}

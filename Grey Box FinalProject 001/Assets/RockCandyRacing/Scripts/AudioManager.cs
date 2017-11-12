using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(AudioSource AudSource in GetComponents<AudioSource>())
        {
            if(!AudSource.isPlaying)
            {
                Destroy(AudSource);
            }
        }
	}

    public void PlaySound(string FileName, bool looping, float volume, int priority)
    {
        AudioClip audClip = Resources.Load<AudioClip>(FileName);
        AudioSource soundSource = gameObject.AddComponent<AudioSource>() as AudioSource;

        soundSource.priority = priority;
        soundSource.volume = volume;
        soundSource.loop = looping;
        soundSource.clip = audClip;
        soundSource.Play();
    }
}

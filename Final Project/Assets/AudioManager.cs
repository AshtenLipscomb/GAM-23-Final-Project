using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private AudioSource[] sources = new AudioSource[4];
    public AudioClip[] clips = new AudioClip[4];

    void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(gameObject);
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        sources[0].Stop();
        if(arg0.buildIndex == 1)
        {
            Play(1);
        }
        else if (arg0.buildIndex == 2)
        {
            Play(2);
        }
        else if (arg0.buildIndex == 3)
        {
            Play(3);
        }
    }

    void Start()
    {
        for(int i = 0; i < sources.Length; i++)
        {
            AudioSource audSrc = gameObject.AddComponent<AudioSource>();
            sources[i] = audSrc;
            sources[i].clip = clips[i];
        }

        if (true)
        {
            Play(0);
        }
    }

    void Play(int i)
    {
        sources[i].Play();
    }
}
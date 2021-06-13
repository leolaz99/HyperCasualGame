﻿using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;
    
    /// <summary>
    /// Funzione per far partire il suono selezionato
    /// </summary>
    /// <param name="name"> Name of the song</param>
    /// <param name="volume"> Volume of the song </param>
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    /// <summary>
    /// Funzione per stoppare il suono selezionato
    /// </summary>
    /// <param name="name"> Name of the song </param>
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
            
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }

        Play("MainMusic");
    }
}

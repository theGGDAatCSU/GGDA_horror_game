using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider master;
    public Slider bgm;
    public Slider sfx;

    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void ChangeMaster()
    {
        mixer.SetFloat("MasterVolume", Mathf.Log10(master.value) * 20);
    }
    public void ChangeBGM()
    {
        mixer.SetFloat("BGMVolume", Mathf.Log10(master.value) * 20);
    }
    public void ChangeSFX()
    {
        mixer.SetFloat("SFXVolume", Mathf.Log10(master.value) * 20);
    }
}

using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    float menuVolume;
    public AudioSource myAudio;

    public Slider masterSlider;

    public Slider bgmSlider;

    public Slider sfxSlider;

    public Sound[] sounds;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        myAudio.volume = bgmSlider.value;
    }

    public void ChangeMaster()
    {
        //float x = masterSlider.value;
        //mixer.SetFloat("MasterVolume", Mathf.Log10(x) * 20);
    }
    public void ChangeBGM()
    {
        //bgmSlider.value = myAudio.volume;
        //this.GetComponent<AudioSource>().volume = masterSlider.value;
    }
    public void ChangeSFX()
    {
        //mixer.SetFloat("SFXVolume", Mathf.Log10(sfxSlider.value) * 20);
    }
}

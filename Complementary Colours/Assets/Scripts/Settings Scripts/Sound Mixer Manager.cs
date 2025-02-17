using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMixerManager : MonoBehaviour
{
    
    [SerializeField]
    private AudioMixer audioMixer;

    public void setMasterVolume(float level){
        audioMixer.SetFloat("Master Volume", Mathf.Log10(level) * 20f);
    }

    public void setSFXVolume(float level){
        audioMixer.SetFloat("SFX Volume", Mathf.Log10(level) * 20f);
    }
    public void setMusicVolume(float level){
        audioMixer.SetFloat("Music Volume", Mathf.Log10(level) * 20f);
    }

}

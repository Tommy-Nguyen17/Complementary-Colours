using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sfxmanager : MonoBehaviour
{
    public static sfxmanager instance;

    [SerializeField]
    private AudioSource sfxObject;
    
    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }

    public void playSoundFXClip(AudioClip clip, Transform spawnTransform, float volume) {
        //spawn in GameObject
        AudioSource audioSource = Instantiate(sfxObject, spawnTransform.position, Quaternion.identity);

        //Assign Clip
        audioSource.clip = clip;

        //Assign Volume
        audioSource.volume = volume;

        //Play Sound
        audioSource.Play();

        //Get Length of Clip
        float clipLength = audioSource.clip.length;

        //Destroy Cliip after it's done playing
        Destroy(audioSource.gameObject, clipLength);
    }
}

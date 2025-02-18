using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAllMusic : MonoBehaviour
{
    [SerializeField]
    public AudioSource[] songsArray;

    public void StopAudio() {
        for(int i = 0; i < songsArray.Length; i++) {
            songsArray[i].Stop();
        }
    }
}

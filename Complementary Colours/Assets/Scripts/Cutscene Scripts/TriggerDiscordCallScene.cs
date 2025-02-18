using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TriggerDiscordCallScene : MonoBehaviour
{
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene(7);
        }
    }
}

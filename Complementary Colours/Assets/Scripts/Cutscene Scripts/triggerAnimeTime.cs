using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class triggerAnimeTime : MonoBehaviour
{
    private bool inFrontOfComputer = false;

    void Update() {
        if(inFrontOfComputer) {
            if(Input.GetKeyDown(KeyCode.E)) {
                SceneManager.LoadScene(15);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!inFrontOfComputer) {
            inFrontOfComputer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       inFrontOfComputer = false;
    }
}

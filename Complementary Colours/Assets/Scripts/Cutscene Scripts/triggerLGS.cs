using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class triggerLGS : MonoBehaviour
{
    private bool inFrontOfLGS = false;

    void Update() {
        if(inFrontOfLGS) {
            if(Input.GetKeyDown(KeyCode.E)) {
                SceneManager.LoadScene(11);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!inFrontOfLGS) {
            inFrontOfLGS = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       inFrontOfLGS = false;
    }
}

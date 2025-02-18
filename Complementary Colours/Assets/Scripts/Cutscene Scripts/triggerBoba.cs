using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class triggerBoba : MonoBehaviour
{
    private bool inFrontOfBoba = false;

    void Update() {
        if(inFrontOfBoba) {
            if(Input.GetKeyDown(KeyCode.E)) {
                SceneManager.LoadScene(13);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!inFrontOfBoba) {
            inFrontOfBoba = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       inFrontOfBoba = false;
    }
}

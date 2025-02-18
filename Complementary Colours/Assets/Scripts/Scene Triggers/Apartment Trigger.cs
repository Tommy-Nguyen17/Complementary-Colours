using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ApartmentTrigger : MonoBehaviour
{
    private bool inFrontOfApartment = false;

    void Update() {
        if(inFrontOfApartment) {
            if(Input.GetKeyDown(KeyCode.E)) {
                SceneManager.LoadScene(2);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!inFrontOfApartment) {
            inFrontOfApartment = true;
            Debug.Log(inFrontOfApartment);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       inFrontOfApartment = false;
       Debug.Log(inFrontOfApartment);
    }




}

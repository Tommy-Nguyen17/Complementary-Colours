using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class BackToApartment : MonoBehaviour
{
  
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene(2);
        }
    }


}

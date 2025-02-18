using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class mutedApartmentTrigger : MonoBehaviour
{
    void Update() {
        if(Input.GetKeyDown(KeyCode.E)) {
                SceneManager.LoadScene(6);
        }
    }
}

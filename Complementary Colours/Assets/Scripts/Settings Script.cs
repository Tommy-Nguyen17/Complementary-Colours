using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public GameObject settingsCanvas, mainMenuCanvas;

    void Start() {
        settingsCanvas.SetActive(false);
    }

    public void openSettings() {
        mainMenuCanvas.SetActive(false);
        settingsCanvas.SetActive(true);
    }
}

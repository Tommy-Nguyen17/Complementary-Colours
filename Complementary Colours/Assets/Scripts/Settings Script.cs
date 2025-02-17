using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    public GameObject settingsCanvas, mainMenuCanvas;

    public void openSettings() {
        settingsCanvas.SetActive(true);

        mainMenuCanvas.SetActive(false);
    }

    public void backButton() {
        mainMenuCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
    }

    public void playButton() {
        SceneManager.LoadScene(1);
    }

    public void doExitGame() {
        Application.Quit();
    }

}

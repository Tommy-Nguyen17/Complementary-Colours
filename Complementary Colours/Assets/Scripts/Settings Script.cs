using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    public GameObject settingsCanvas, mainMenuCanvas, pauseMenuCanvas;

    public bool settingsAreOpened = false;

    public void openSettings() {
        settingsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(false);
    }

    public void openClosePause() {
        if(!settingsAreOpened) {
            settingsAreOpened = true;
            mainMenuCanvas.SetActive(true);
        } else {
            settingsAreOpened = false;
            mainMenuCanvas.SetActive(false);
        }  
    }



    public void backButton() {
        mainMenuCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(true);
    }

    public void playButton() {
        SceneManager.LoadScene(1);
        mainMenuCanvas.SetActive(false);
        settingsCanvas.SetActive(false);
    }

    public void doExitGame() {
        Application.Quit();
    }

}

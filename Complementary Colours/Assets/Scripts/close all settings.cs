using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeallsettings : MonoBehaviour
{

    public GameObject settingsCanvas, mainMenuCanvas, pauseMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        settingsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(true);
    }


}

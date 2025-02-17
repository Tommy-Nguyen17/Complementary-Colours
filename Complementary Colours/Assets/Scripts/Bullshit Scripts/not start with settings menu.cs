using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notstartwithsettingsmenu : MonoBehaviour
{

     public GameObject settingsCanvas, pauseMenuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        settingsCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(false);
    }
}

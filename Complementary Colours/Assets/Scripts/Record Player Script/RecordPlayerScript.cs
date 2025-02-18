using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayerScript : MonoBehaviour
{
    public GameObject recordCanvas;

    private bool inFrontOfRecordPlayer;

    void Start() {
        recordCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(inFrontOfRecordPlayer) {
            if(Input.GetKeyDown(KeyCode.E)) {
                recordCanvas.SetActive(true);
            }
        } else {
            recordCanvas.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!inFrontOfRecordPlayer) {
            inFrontOfRecordPlayer = true;
        }
    }

    
    private void OnTriggerExit2D(Collider2D other)
    {
       inFrontOfRecordPlayer = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState pretty much just locks the cursor in the center of the screen. 
        //It also ensures that that cursor is invisible, regardless whether or not the cursor is set to 
        //visible elsewhere. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

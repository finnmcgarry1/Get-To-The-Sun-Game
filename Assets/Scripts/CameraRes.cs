using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRes : MonoBehaviour
{
    public Resolution currentResolution;
    
    void Start()
    {
        // Switch to 800 x 600 windowed
        Screen.SetResolution(800, 600, false);
    }
}

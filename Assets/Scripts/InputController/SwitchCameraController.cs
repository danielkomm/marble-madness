using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraController : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex;
    
    void Start()
    {
        currentCameraIndex = 0;
        //cameras[currentCameraIndex].enabled = true;
    }
    private void OnSwitchCamera()
    {
        cameras[currentCameraIndex].enabled = false;

        if(currentCameraIndex < cameras.Length - 1){
            currentCameraIndex++;
        } else {
           currentCameraIndex = 0; 
        }
        cameras[currentCameraIndex].enabled = true;
    }

    public Camera GetCurrentCamera(){
        Debug.Log("IndexOfCam" + currentCameraIndex);
        return cameras[currentCameraIndex];
    }
}

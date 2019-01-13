 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;

    public bool camSwitch = false;

    void Start()
    {
        cameraOne = (Camera)GameObject.FindGameObjectWithTag("CameraOne").GetComponent("Camera");

        cameraTwo = (Camera)GameObject.FindGameObjectWithTag("CameraTwo").GetComponent("Camera");

        // Initial ist FPSCam aktiv.
        cameraOne.gameObject.SetActive(true);
        cameraTwo.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {

            camSwitch = !camSwitch;
        }

        if (camSwitch)
        {
            cameraOne.gameObject.SetActive(false);
            cameraTwo.gameObject.SetActive(true);
        }

        if (!camSwitch)
        {
            cameraOne.gameObject.SetActive(true);
            cameraTwo.gameObject.SetActive(false);
        }
    }
}
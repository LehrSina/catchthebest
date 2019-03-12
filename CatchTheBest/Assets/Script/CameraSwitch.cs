 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    /*
     * Quellenangabe:
     * https://www.youtube.com/watch?v=vZXGbTdk8gA
     * 
     */

    public Camera cameraEins;
    public Camera cameraZwei;

    public bool camSwitch = false;

    void Start()
    {
        cameraEins = (Camera)GameObject.FindGameObjectWithTag("CameraOne").GetComponent("Camera");
        //Debug.Log(cameraEins.transform.position);
        //Debug.Log("test");
        cameraZwei = (Camera)GameObject.FindGameObjectWithTag("CameraTwo").GetComponent("Camera");

        // Initial ist CameraOne aktiv.
        cameraEins.gameObject.SetActive(true);
        cameraZwei.gameObject.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("pressed button");
            camSwitch = !camSwitch;
        }

        if (camSwitch)
        {
            cameraEins.gameObject.SetActive(false);
            cameraZwei.gameObject.SetActive(true);
        }

        if (!camSwitch)
        {
            cameraEins.gameObject.SetActive(true);
            cameraZwei.gameObject.SetActive(false);
        }
    }
}

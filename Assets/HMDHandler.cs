using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is Device Active " + XRSettings.isDeviceActive);
        Debug.Log("The device name is " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No HMD");
        }
        else if (XRSettings.isDeviceActive &&
            (XRSettings.loadedDeviceName == "Mock HMD"
             || XRSettings.loadedDeviceName == "MockHMD Display"))
        {
            Debug.Log("Uisng Mock HMD");
        }
        else
        {
            Debug.Log("We have a headset " + XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

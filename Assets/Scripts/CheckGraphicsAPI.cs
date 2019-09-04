using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGraphicsAPI : MonoBehaviour
{
    void Update()
    {
        
        GetComponent<UnityEngine.UI.Text>().text = "Current Graphics API: " + SystemInfo.graphicsDeviceType;
    }
}

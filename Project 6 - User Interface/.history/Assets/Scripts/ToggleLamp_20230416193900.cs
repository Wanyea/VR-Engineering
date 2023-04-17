using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLamp : MonoBehaviour
{
    [SerializeField] private GameObject lampLightSource;
    private bool isLampOn = false;

    public void ToggleLampLight() 
    {
        if (!isLampOn) 
        {
            lampLightSource.SetActive(true);
            isLampOn = !isLampOn;
        } else {
            lampLightSource.SetActive(false);
            isLampOn = !isLampOn;
        }
    }
}

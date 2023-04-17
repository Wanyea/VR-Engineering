using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSkybox : MonoBehaviour
{   
    [SerializeField] private Material[] skyboxes;

    public void ChangeSkybox() 
    {
        Debug.Log("Skybox button pressed...");
        int length = skyboxes.Length - 1;
        RenderSettings.skybox = skyboxes[Random.Range(0, length)];
    }
}

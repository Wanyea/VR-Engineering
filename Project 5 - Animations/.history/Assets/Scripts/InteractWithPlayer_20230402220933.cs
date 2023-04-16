using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPlayer : MonoBehaviour
{
    public GameObject greeterBot;
    [HideInInspector] public boolean isPlayerInLab = false;


    void Update() 
    {
        if (isPlayerInLab) 
        {
            
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            greeterBot.transform = 
        }
    }
}

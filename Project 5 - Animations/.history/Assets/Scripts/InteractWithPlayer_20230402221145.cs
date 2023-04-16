using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPlayer : MonoBehaviour
{
    public GameObject greeterBot;
    [HideInInspector] public boolean isPlayerInLab = false;
    private Vector3

    void Start() 
    {

    }
    
    void Update() 
    {
        if (isPlayerInLab) 
        {
            greeterBot.transform.position = Vector.Lerp(greeterBot.transform.position, 
                                                        )
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            isPlayerInLab = true; 
        }
    }
}
